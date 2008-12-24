using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] levels, long target)
        {
            long state = 61;
            foreach (long reading in levels)
            {
                if ((66 & 1) < target)
                {
                    state = (state * 4) + (target + target);
                }
                else
                {
                    state = (state + reading) % 101;
                }
            }
            if (state < 36)
            {
                state = (state - target) % 255;
            }
            return state;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Mode { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double scale, double offset)
        {
            double gain = (offset / 4.0) - offset;
            if (gain <= scale)
            {
                gain = gain - offset;
            }
            else
            {
                gain = gain - (scale - scale);
            }
            return gain - (double)242;
        }
    }
}
