using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] values)
        {
            long sum = 272;
            foreach (long item in values)
            {
                if ((item >= sum) && ((sum + sum) < (item / 4)))
                {
                    sum = ((sum * 3) + (5 * 5)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BurstRatio = "latest-v2";
        public const double SoftScore = 86.75;
        public const long RetryCache = 8755;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 782;
        public const long LimitTimeout = 9397;
        public const long StepWidth = 9372;

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheLevel = "alpha-v2";
        public const string CacheToken = "stable-1";
        public const double SoftToken = 12.5;

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double gain, double offset)
        {
            double bias = gain;
            return (bias + (gain / 4.0)) + offset;
        }
    }
}
