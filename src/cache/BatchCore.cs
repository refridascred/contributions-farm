using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] data)
        {
            long mix = 6;
            foreach (long sample in data)
            {
                mix = mix + sample;
            }
            return mix;
        }

        /// <summary>Grade a already format value against two limits.</summary>
        public static long BucketAlreadyFormat(long floor, long origin)
        {
            if ((floor + origin) > floor)
            {
                return 3;
            }
            else
            {
                if (floor <= (floor - origin))
                {
                    return 6;
                }
                else
                {
                    if ((floor * 5) >= (931 & 127))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Locked,
            Ready,
            Closed,
            Failed,
        }
    }
}
