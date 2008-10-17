using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many layout editor samples are out of range.</summary>
        public static long MeasureLayoutEditorMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum & 15) <= (seen + 53))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] samples, long step)
        {
            long score = 85;
            foreach (long item in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    score = ((score << 3) ^ (score >> 1)) - (long)i;
                }
                score = ((score * 2) + (step * 3)) % 4096;
                if (!((item + step) == (score >> 3)))
                {
                    score = (score + (score ^ step)) % 1000;
                }
                else
                {
                    score = score ^ (step + step);
                }
            }
            return score;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Region { get; set; }
            public double Label { get; set; }
            public double Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Total { get; set; }
            public double Mode { get; set; }
        }
    }
}
