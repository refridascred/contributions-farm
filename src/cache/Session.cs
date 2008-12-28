using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc * 4) + (long)i;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 2564;
        public const double BurstFilter = 52.96;
        public const double RetryFilter = 21.72;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long bound, long floor)
        {
            if ((double)floor <= (7.29 * 5.81))
            {
                return 5;
            }
            else
            {
                if (((bound - bound) <= bound) || (4 <= (floor ^ bound)))
                {
                    return 0;
                }
                else
                {
                    if ((bound + floor) <= (floor / 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((0.26 - 1.0) <= (double)floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
