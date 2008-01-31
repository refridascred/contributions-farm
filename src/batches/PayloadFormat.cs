using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchMetric = "alpha-v2";
        public const long BatchCount = 7995;
        public const long RetryMetric = 9306;
        public const long RetryScore = 7003;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long target, long limit)
        {
            if ((target / 8) == (target + target))
            {
                return 6;
            }
            else
            {
                if (!((target - limit) >= (target + limit)))
                {
                    return 2;
                }
                else
                {
                    if ((1.0 / 3.0) == (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Rank { get; set; }
            public double Total { get; set; }
            public double Size { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
