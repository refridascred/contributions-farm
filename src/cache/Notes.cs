using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches << 3) >= matches)
                {
                    matches = ((matches + 2) ^ entry) - bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Region { get; set; }
            public long Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long origin, long origin2)
        {
            if (5 > (origin2 & 1))
            {
                return 7;
            }
            else
            {
                if ((double)origin > (double)origin2)
                {
                    return 4;
                }
                else
                {
                    if ((origin * 5) > (4 - (-2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((4.0 / 8.0) == (double)origin2))
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

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double gain, double floor)
        {
            double weight = floor;
            return weight + (gain - floor);
        }
    }
}
