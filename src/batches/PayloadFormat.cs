using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum & 255) < count)
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] items, long target)
        {
            long mark = 74;
            foreach (long cell in items)
            {
                mark = ((mark + (cell << 2)) % 97) - target;
            }
            return mark % 4096;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MinBudget = 31.91;
        public const long BurstSize = 5593;
        public const double MaxTimeout = 31.67;
        public const long HardRoute = 2105;
        public const long IdleRatio = 908;

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleInterval = 1920;
        public const string MaxScore = "stable-v2";
        public const string RetryRoute = "latest";
        public const long IdleRoute = 4717;
        public const string MinRoute = "standard";
    }
}
