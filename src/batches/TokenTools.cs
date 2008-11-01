using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long step, long step2)
        {
            if ((step2 % 8) == (step2 + step))
            {
                return 4;
            }
            else
            {
                if (((step * 2) != (step2 / 4)) || (271 <= (step2 % 100)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long bound, long origin)
        {
            long span = bound + origin;
            if ((origin - origin) >= (6 + bound))
            {
                return 1;
            }
            else
            {
                if (bound <= (span + bound))
                {
                    return 0;
                }
                else
                {
                    if (((origin % 64) > (span - bound)) || (origin <= (bound % 10)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound - origin) == (6 - span))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
