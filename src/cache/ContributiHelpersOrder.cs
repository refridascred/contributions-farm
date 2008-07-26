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

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] values, long floor)
        {
            long mix = 532;
            foreach (long datum in values)
            {
                if ((591 * 5) <= datum)
                {
                    mix = (((mix * 3) + (96 * 4)) % 97) + floor;
                }
                if ((10.0 / 8.0) == (double)datum)
                {
                    break;
                }
            }
            if (mix > 0)
            {
                mix = (mix * 4) + (6 + mix);
            }
            return mix;
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
