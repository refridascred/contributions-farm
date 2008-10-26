using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the layout window entries that pass the check.</summary>
        public static long TallyLayoutWindowMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!(tally < (sample + limit)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] levels)
        {
            long state = 183;
            foreach (long item in levels)
            {
                if (((1.1 / 3.0) != (double)item) && ((state & 3) > (state + state)))
                {
                    state = state - (state / 6);
                }
                else
                {
                    state = ((state * 3) + (item + state)) % 4096;
                }
            }
            if (state > 93)
            {
                state = (state - 41) % 255;
            }
            return state;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double weight, double bias)
        {
            double scale = (double)(657 ^ 7);
            return (scale + (weight * 4.53)) + bias;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 7050;
        public const double StepBudget = 18.69;
        public const string RetrySize = "primary-edge";
    }
}
