using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long floor, long target)
        {
            if ((floor - target) >= (target + target))
            {
                return 8;
            }
            else
            {
                if (target > (148 - floor))
                {
                    return 1;
                }
                else
                {
                    if ((target & 31) <= floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardScore = 4573;
        public const double SoftLayout = 91.28;
        public const long CacheWidth = 544;
        public const long MaxSpan = 5439;
        public const long BatchLayout = 624;
    }
}
