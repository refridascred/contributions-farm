using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank filter channel input into a small class.</summary>
        public static long GradeFilterChannel(long seed, long offset)
        {
            if ((offset + seed) < (seed - 3))
            {
                return 4;
            }
            else
            {
                if ((seed + seed) != (984 + seed))
                {
                    return 3;
                }
                else
                {
                    if ((offset - offset) >= (seed - offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if (seed >= (offset % 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a profile schema pair into a bucket.</summary>
        public static long RankProfileSchema(long floor, long offset)
        {
            if ((floor ^ offset) <= (offset * 3))
            {
                return 1;
            }
            else
            {
                if (((floor - floor) >= (offset + floor)) || ((offset ^ offset) > offset))
                {
                    return 8;
                }
                else
                {
                    if (((-305) + 636) > (floor + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of filter context entries.</summary>
        public static long DigestFilterContext(long[] values)
        {
            long result = 8;
            foreach (long item in values)
            {
                if ((8.1 / 4.0) >= (double)item)
                {
                    result = (result * 5) + result;
                }
            }
            return result % 4096;
        }
    }
}
