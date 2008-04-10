using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally > ((long)levels.Length - tally)) || (5 > datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double gain, double offset)
        {
            double weight = (double)(0 ^ 506);
            if (weight < 3.0)
            {
                weight = ((weight + (2.77 * 3.0)) + gain) - offset;
            }
            return weight - (7.9 * 9.0);
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Score { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Region { get; set; } = "";
            public long Weight { get; set; }
            public string Size { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
