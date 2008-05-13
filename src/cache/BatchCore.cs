using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a context format reading by value.</summary>
        public static long LocateContextFormatIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long origin, long limit)
        {
            long diff = origin ^ limit;
            if (!((double)diff < (3.0 * 4.64)))
            {
                return 6;
            }
            else
            {
                if ((diff + diff) <= (origin + origin))
                {
                    return 8;
                }
                else
                {
                    if (((limit & 3) < (limit & 1)) && ((diff & 63) <= (origin * 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin * 5) < (limit / 8))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Closed,
            Draft,
            Pending,
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
