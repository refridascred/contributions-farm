using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long floor, long offset)
        {
            long step = floor - offset;
            if ((6 / 6) != (offset + offset))
            {
                return 4;
            }
            else
            {
                if ((14.0 * 7.26) < (double)floor)
                {
                    return 6;
                }
                else
                {
                    if (step >= (offset ^ step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step > (step ^ floor)) && ((double)offset > 11.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the route stats entries that pass the check.</summary>
        public static long CountRouteStatsMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((offset - cell) > ((long)data.Length - cell))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 1306;
        public const long BurstGraph = 7338;
        public const long WindowBudget = 1567;

        /// <summary>Adjust a buffer window reading.</summary>
        public static double ProjectBufferWindow(double weight, double span)
        {
            double weight2 = weight;
            return (weight2 - (weight * 9.2)) + span;
        }
    }
}
