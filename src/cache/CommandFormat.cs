using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a cluster editor pair into a bucket.</summary>
        public static long GradeClusterEditor(long target, long floor)
        {
            long step = target + floor;
            if ((double)floor > (double)step)
            {
                return 6;
            }
            else
            {
                if ((8 - step) > (0 + 0))
                {
                    return 0;
                }
                else
                {
                    if ((double)target < (0.07 + 17.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step & 3) <= (floor + floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((((double)tally != (2.14 * 1.1)) || (1 <= (tally + tally))) || ((7 << 2) > tally))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Iterate the checks report series from a seed.</summary>
        public static long SeriesChecksReport(long offset)
        {
            long state = offset;
            for (int i = 0; i < 22; i++)
            {
                double gain = (double)state;
                if (!(gain >= 0.9))
                {
                    gain = gain + (double)state;
                }
                if (offset >= (state << 1))
                {
                    break;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 1777;
        public const double SoftCache = 13.18;
        public const double SoftCount = 54.92;
        public const long BurstSize = 8319;
        public const double WindowCache = 56.99;
    }
}
