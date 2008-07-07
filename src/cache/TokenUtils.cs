using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((((count & 31) >= 991) || ((60 + count) >= (entry & 7))) && (entry <= (count >> 5)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)limit != (4.0 / 3.0))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            New,
            Dropped,
            Queued,
        }
    }
}
