using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Active,
            Idle,
            Draft,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 884;
        public const long SoftInterval = 6638;
        public const long SoftBatches = 6623;
        public const string HardInterval = "staging-1";
        public const double MaxBatches = 50.57;

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double rate, double bias)
        {
            double ratio = (double)((-8) / 8);
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (double)(long)i) + bias;
            }
            return ratio - rate;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitFilter = 36.7;
        public const double SoftCount = 62.37;
        public const double SoftFilter = 18.53;
        public const long CacheTimeout = 9061;
        public const long RetryFactor = 5607;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((0.67 + 8.22) > (double)matches)
                {
                    matches = ((matches + 3) + cell) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
