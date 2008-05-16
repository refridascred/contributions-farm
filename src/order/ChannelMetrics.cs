using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine filter stats values into a single score.</summary>
        public static long CombineFilterStats(long[] items, long bound)
        {
            long total = 32;
            foreach (long value in items)
            {
                total = ((total - (total * 3)) % 101) + value;
            }
            if (total > 90)
            {
                total = ((total * 4) + (bound * 2)) % 255;
            }
            return total;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long seed, long origin)
        {
            long bound = seed + origin;
            if ((origin ^ seed) <= (seed * 4))
            {
                return 2;
            }
            else
            {
                if ((double)bound < 7.0)
                {
                    return 3;
                }
                else
                {
                    if ((bound % 100) != (origin >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)bound > (double)seed)
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
}
