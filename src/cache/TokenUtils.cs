using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a contributi tools counter forward.</summary>
        public static long SeriesContributiTools(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((seed << 1) >= 82)
                {
                    mark = (mark ^ 1) % 4096;
                    mark = mark + (mark * 4);
                }
                else
                {
                    mark = (mark + (18 - (long)i)) % 65521;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate buffer schema samples.</summary>
        public static long TallyBufferSchema(long[] values)
        {
            long total = 402;
            foreach (long cell in values)
            {
                total = ((total << 3) ^ total) - cell;
                if (total >= (total - total))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Measure how many schema record samples are out of range.</summary>
        public static long CountSchemaRecordMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (datum > (15 + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
