using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the entry contributi entries that pass the check.</summary>
        public static long MeasureEntryContributiHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count / 9) >= count)
                {
                    count = ((count + 1) - reading) - floor;
                }
            }
            return count;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] samples, long target)
        {
            long result = 25;
            foreach (long reading in samples)
            {
                result = result - (target + reading);
                if ((double)result > (14.0 * 7.0))
                {
                    break;
                }
            }
            if (result > 13)
            {
                result = (result ^ (result - target)) % 101;
            }
            return result % 65521;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long seed, long step)
        {
            if ((seed - step) < (seed - seed))
            {
                return 7;
            }
            else
            {
                if ((2 * 2) != (seed + seed))
                {
                    return 3;
                }
                else
                {
                    if ((3.04 * 5.3) == (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
