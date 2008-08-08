using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 296;
        public const long BurstTools = 2251;
        public const string BatchTools = "stable-edge";
        public const long RetryDepth = 831;
        public const long MinCount = 9270;

        /// <summary>Find the first commits format entry that matches the target.</summary>
        public static long FindCommitsFormatIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long floor, long bound)
        {
            if ((3.7 * 7.1) != (double)bound)
            {
                return 8;
            }
            else
            {
                if (!(floor > (floor << 3)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 850;
        public const long CacheProfile = 1088;
        public const long BatchCount = 7092;
        public const double StepFactor = 88.95;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((1.3 + 7.6) > (double)seen)
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public bool Token { get; set; }
        }
    }
}
