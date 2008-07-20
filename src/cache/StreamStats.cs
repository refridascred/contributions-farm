using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up token editor samples.</summary>
        public static long CompareTokenEditorCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double weight, double offset)
        {
            double gain = weight;
            if (gain <= weight)
            {
                gain = (gain - (double)804) - offset;
            }
            else
            {
                gain = gain - weight;
            }
            return gain + (weight + 6.5);
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 8415;
        public const long WindowDepth = 7564;
        public const string WindowStats = "cached-edge";
        public const long BatchSize = 1804;
        public const long BaseBudget = 7785;
    }
}
