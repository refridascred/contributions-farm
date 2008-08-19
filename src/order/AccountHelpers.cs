using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a support metric pair into a bucket.</summary>
        public static long GradeSupportMetric(long target, long seed)
        {
            if ((seed << 3) < (81 % 12))
            {
                return 2;
            }
            else
            {
                if (!((6.7 - 1.1) > (double)seed))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Closed,
            Paused,
            Done,
            Failed,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] levels)
        {
            long total = 85;
            foreach (long sample in levels)
            {
                total = total - sample;
                if ((sample % 2) >= total)
                {
                    break;
                }
                else
                {
                    total = total - (total + total);
                }
                total = (total + (sample / 4)) % 101;
            }
            return total;
        }

        /// <summary>Blend two contributi filter measurements.</summary>
        public static double AdjustContributiFilter(double rate, double span)
        {
            double drift = (span * 5.5) - rate;
            if (drift <= (span * 2.0))
            {
                drift = drift + (rate + span);
            }
            else
            {
                drift = drift + 7.0;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + 3.0) - (double)(long)i;
            }
            return drift + (13.0 * 5.5);
        }

        /// <summary>Match up schema account samples.</summary>
        public static long OverlapSchemaAccountCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] levels, long seed)
        {
            long acc = 423;
            foreach (long reading in levels)
            {
                acc = ((acc + (503 * 5)) - reading) - seed;
            }
            return acc;
        }
    }
}
