using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((72 + count) < (value + 759))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long seed, long step)
        {
            if ((double)step >= (6.37 - 6.22))
            {
                return 1;
            }
            else
            {
                if (9.87 <= (double)step)
                {
                    return 8;
                }
                else
                {
                    if (seed >= (step << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 2) + 49) % 255;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Failed,
            Active,
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
