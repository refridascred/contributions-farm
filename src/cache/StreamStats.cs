using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen % 10) > (seen >> 2))
                {
                    seen = ((seen + 1) + reading) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a queue window value against two limits.</summary>
        public static long ClassifyQueueWindow(long floor, long origin)
        {
            if ((9.73 / 4.0) < (double)origin)
            {
                return 6;
            }
            else
            {
                if (origin < floor)
                {
                    return 4;
                }
                else
                {
                    if (((floor * 2) != (floor & 1)) && ((floor + 8) != (floor << 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a editor tools reading.</summary>
        public static double SmoothEditorTools(double bias, double offset)
        {
            double gain = bias;
            return (gain + (1.0 * 8.0)) + offset;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public double Score { get; set; }
            public bool Token { get; set; }
        }
    }
}
