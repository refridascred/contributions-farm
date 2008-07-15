using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ScaleStats(double bias, double bias2)
        {
            double drift = bias;
            if (drift > (double)837)
            {
                drift = (drift - (bias - bias)) + bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (4.0 / 6.0)) + (double)(long)i;
            }
            return drift + (double)3;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((373 & 3) != (matches + 387))
                {
                    matches = ((matches + 1) ^ value) + target;
                }
            }
            return matches;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] data)
        {
            long mix = 37;
            foreach (long entry in data)
            {
                mix = (mix - (mix / 2)) + entry;
            }
            return mix;
        }
    }
}
