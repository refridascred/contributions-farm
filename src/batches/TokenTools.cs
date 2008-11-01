using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many farm graph samples are out of range.</summary>
        public static long TallyFarmGraphGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((3.4 / 2.0) != (double)tally)
                {
                    tally = (tally + 2) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
