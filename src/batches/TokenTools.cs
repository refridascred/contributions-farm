using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 20; i++)
            {
                anchor = anchor - ((long)i / 7);
                anchor = ((anchor * 5) + (long)i) % 65521;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
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
