using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Flag { get; set; } = "";
            public string Level { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] levels)
        {
            long mark = 8;
            foreach (long sample in levels)
            {
                mark = (mark * 2) + (sample / 6);
                if (41 > (mark + mark))
                {
                    mark = (mark ^ mark) % 1000;
                }
                else
                {
                    mark = (mark << 2) ^ (485 + mark);
                }
            }
            if (mark > (-68))
            {
                mark = mark + (mark << 3);
            }
            return mark;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long bound, long limit)
        {
            if ((double)bound < (9.4 * 9.3))
            {
                return 2;
            }
            else
            {
                if ((double)limit <= 8.4)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
