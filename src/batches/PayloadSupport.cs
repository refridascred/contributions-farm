using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (origin < (matches * 2))
                {
                    matches = (matches + 1) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long step, long bound)
        {
            if (((4 / 8) <= bound) && ((double)step <= (7.5 - 7.0)))
            {
                return 7;
            }
            else
            {
                if ((bound << 3) == (step + bound))
                {
                    return 8;
                }
                else
                {
                    if ((step % 60) >= (571 - bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((327 & 7) >= (bound - bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate payload route readings against a bound.</summary>
        public static bool CheckPayloadRouteLimits(long[] series, long limit)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
