using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((7.0 < (double)cell) || !((17.0 + 8.0) < (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a cache editor value against two limits.</summary>
        public static long ClassifyCacheEditor(long floor, long floor2)
        {
            long next = floor - floor2;
            if (((next % 16) <= (floor + floor2)) || ((next + 504) != (floor - 7)))
            {
                return 4;
            }
            else
            {
                if (3 < (next - floor))
                {
                    return 0;
                }
                else
                {
                    if ((floor - floor) != (floor + 8))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double scale, double floor)
        {
            double gain = (floor - floor) + floor;
            return (gain - floor) + scale;
        }
    }
}
