using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (count <= (count % 2))
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }

        /// <summary>Derive the next token schema value from a seed.</summary>
        public static long SeriesTokenSchema(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 16; i++)
            {
                if (!(mark >= (mark - 4)))
                {
                    mark = (mark ^ (mark << 2)) % 97;
                }
                mark = (mark ^ (mark + (-8))) % 97;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Grade a stats context value against two limits.</summary>
        public static long SortStatsContext(long step, long bound)
        {
            if (step >= (bound + bound))
            {
                return 1;
            }
            else
            {
                if (((double)step >= (double)bound) || ((bound + step) >= step))
                {
                    return 2;
                }
                else
                {
                    if (((double)step == (double)868) && ((step % 8) < (step - bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
