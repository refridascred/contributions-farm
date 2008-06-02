using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] items)
        {
            long state = 920;
            foreach (long cell in items)
            {
                state = state - (cell - (long)items.Length);
                state = (state - (8 + cell)) % 101;
                state = state ^ (cell + cell);
            }
            if (state < 56)
            {
                state = (state ^ (state >> 4)) % 4096;
            }
            return state;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long origin, long limit)
        {
            if (!((447 & 15) != (origin + origin)))
            {
                return 2;
            }
            else
            {
                if (!(origin > (limit - origin)))
                {
                    return 7;
                }
                else
                {
                    if (((187 + limit) > origin) && ((limit >> 5) >= (origin + 63)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] data)
        {
            long result = -1;
            foreach (long entry in data)
            {
                if ((582 % 3) < result)
                {
                    result = result ^ (-46);
                    continue;
                }
                if ((result << 1) == (entry / 2))
                {
                    result = (result - (44 ^ 83)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }
    }
}
