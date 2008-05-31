using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double gain, double offset)
        {
            double load = (double)(678 % 12);
            return ((load + load) + gain) + offset;
        }

        /// <summary>Measure how many tools account samples are out of range.</summary>
        public static long MeasureToolsAccountOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((double)cell == (2.0 - 20.0)) && ((matches - cell) < 756))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the command format entries that pass the check.</summary>
        public static long TallyCommandFormatGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches - (-92)) < (reading << 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Total { get; set; }
            public string Score { get; set; } = "";
            public double Mode { get; set; }
            public double Weight { get; set; }
        }
    }
}
