using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a cluster tools counter forward.</summary>
        public static long StepClusterTools(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                if (83 <= (seed + 3))
                {
                    break;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate checks channel samples.</summary>
        public static long TotalChecksChannel(long[] values, long target)
        {
            long sum = 9;
            foreach (long value in values)
            {
                sum = ((((sum * 4) + sum) % 255) ^ value) - target;
            }
            return sum % 1000;
        }
    }
}
