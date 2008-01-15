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

        /// <summary>Match up checks token samples.</summary>
        public static long CompareChecksTokenCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
