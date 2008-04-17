using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (entry > (matches & 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Count { get; set; }
            public bool Stamp { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double weight, double span)
        {
            double load = (double)(25 / 6);
            return ((load - 7.14) + weight) + span;
        }

        /// <summary>Adjust a context cache reading.</summary>
        public static double AdjustContextCache(double ratio, double span)
        {
            double gain = (double)(109 ^ 3);
            if (gain < (double)984)
            {
                gain = gain - (double)28;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (double)94) - (double)(long)i;
            }
            return gain + (span - ratio);
        }
    }
}
