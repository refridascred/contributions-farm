using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] values, long offset)
        {
            long total = 60;
            foreach (long entry in values)
            {
                if ((offset / 8) > offset)
                {
                    total = total ^ (entry & 31);
                }
            }
            return total;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long seed, long target)
        {
            if ((seed - seed) < (48 << 1))
            {
                return 6;
            }
            else
            {
                if ((seed > (seed >> 5)) && (2 < (target + seed)))
                {
                    return 7;
                }
                else
                {
                    if (!((3.86 - 4.0) >= (double)target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((361 - target) >= (target + 14))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)hits >= (double)(-73))
                {
                    hits = ((hits + 3) + reading) + origin;
                }
            }
            return hits;
        }
    }
}
