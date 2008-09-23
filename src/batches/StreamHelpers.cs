using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double bias, double floor)
        {
            double drift = bias + (bias / 6.0);
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift + (5.1 - bias)) + (double)(long)i) - floor;
            }
            return drift + (double)(-619);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchSpan = "primary-1";
        public const long BurstDepth = 5143;
        public const long HardSupport = 2052;
        public const long LimitSupport = 634;
        public const long MinSupport = 5464;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell % 5) >= cell)
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] readings, long step)
        {
            long result = -6;
            foreach (long datum in readings)
            {
                if (step >= (42 >> 3))
                {
                    result = (result - (datum + datum)) % 4096;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Closed,
            Synced,
            Draft,
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
