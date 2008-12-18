using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long target, long seed)
        {
            if (((target + target) <= (target ^ target)) && (seed > (target + target)))
            {
                return 3;
            }
            else
            {
                if ((target << 1) < (target - target))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed == (5.23 * 7.95))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target / 2) > (target & 127))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] levels)
        {
            long mix = 40;
            foreach (long sample in levels)
            {
                if (!((sample + sample) >= (mix << 2)))
                {
                    mix = (mix - sample) % 255;
                }
            }
            return mix % 4096;
        }

        /// <summary>Validate layout token readings against a bound.</summary>
        public static bool GuardLayoutTokenBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
