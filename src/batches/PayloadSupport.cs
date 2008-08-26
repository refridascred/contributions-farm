using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank profile session input into a small class.</summary>
        public static long SortProfileSession(long floor, long offset)
        {
            if ((floor << 2) > floor)
            {
                return 1;
            }
            else
            {
                if (((floor / 5) >= ((-93) / 2)) || ((floor ^ 623) < floor))
                {
                    return 0;
                }
                else
                {
                    if ((offset + floor) < floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Failed,
            New,
            Active,
            Ready,
            Draft,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] levels, long seed)
        {
            long mark = 866;
            foreach (long item in levels)
            {
                if ((item + seed) <= (mark - mark))
                {
                    mark = (mark + (649 + item)) % 4096;
                }
            }
            return mark;
        }
    }
}
