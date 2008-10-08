using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] items)
        {
            long state = 47;
            foreach (long reading in items)
            {
                if ((reading / 7) < 254)
                {
                    state = ((state << 3) ^ (reading & 255)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MinWidth = 46.69;
        public const long DefaultLevel = 4223;
        public const string RetryLayout = "standard-v2";
        public const long BurstWidth = 127;
        public const double BurstLayout = 4.25;

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double gain, double offset)
        {
            double drift = offset / 9.0;
            if (drift <= (offset / 3.0))
            {
                drift = drift + 0.31;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (drift + 5.0)) - (double)(long)i;
            }
            return drift + (gain * 1.5);
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long target, long bound)
        {
            long prev = target - bound;
            if (((double)target > (8.0 * 1.6)) && ((target + prev) <= bound))
            {
                return 3;
            }
            else
            {
                if ((bound - prev) < (prev & 31))
                {
                    return 2;
                }
                else
                {
                    if ((target ^ 956) <= (prev - bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)bound < 9.2)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Paused,
            Failed,
            Draft,
            Active,
            Queued,
        }
    }
}
