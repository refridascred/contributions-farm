using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Paused,
            New,
            Dropped,
            Active,
            Idle,
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double ratio, double offset)
        {
            double bias = (double)(326 << 3);
            if (bias <= (double)99)
            {
                bias = (bias - bias) - ratio;
            }
            else
            {
                bias = bias + offset;
            }
            return bias - offset;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
