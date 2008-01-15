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

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!(5 > (1 - (long)readings.Length)) || (entry < (count - entry)))
                {
                    count = count + 2;
                }
            }
            return count;
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
