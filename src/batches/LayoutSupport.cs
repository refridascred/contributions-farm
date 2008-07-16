using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double scale, double bias)
        {
            double ratio = bias;
            if (ratio <= bias)
            {
                ratio = ratio + bias;
            }
            else
            {
                ratio = ratio + scale;
            }
            return ratio + ratio;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample - seed) > seed)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double gain, double span)
        {
            double gain2 = (gain / 6.0) - (double)355;
            if (gain2 > (8.4 * 9.0))
            {
                gain2 = gain2 - (double)679;
            }
            else
            {
                gain2 = gain2 + (span - span);
            }
            return gain2 - (gain2 + 4.82);
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Count { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Derive the next contributi schema value from a seed.</summary>
        public static long StepContributiSchema(long bound)
        {
            long state = bound;
            for (int i = 0; i < 8; i++)
            {
                if (((-125) - (long)i) == (bound >> 3))
                {
                    state = (state - (bound / 5)) % 4096;
                }
                state = ((state * 2) + (bound % 5)) % 65521;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
