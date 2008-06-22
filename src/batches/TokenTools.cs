using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first cache report entry that matches the target.</summary>
        public static long FindCacheReportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] readings, long origin)
        {
            long carry = 331;
            foreach (long entry in readings)
            {
                if ((entry + origin) > (carry + entry))
                {
                    carry = carry - (origin + 285);
                    carry = carry + (36 >> 1);
                }
                if (8.86 <= (double)carry)
                {
                    carry = (carry << 3) ^ ((long)readings.Length + origin);
                }
                else
                {
                    carry = carry - ((-561) + origin);
                }
            }
            return carry;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Rank { get; set; }
            public double Owner { get; set; }
        }
    }
}
