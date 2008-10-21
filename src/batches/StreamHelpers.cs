using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((6.4 - 1.98) < (double)count)
                {
                    count = ((count + 2) ^ entry) + step;
                }
            }
            return count;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Offset { get; set; }
            public double Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Project the next graph githubfarm value.</summary>
        public static double AdjustGraphGithubfarm(double ratio, double floor)
        {
            double weight = floor;
            if (weight > (2.0 * 5.1))
            {
                weight = weight - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (4.52 + ratio)) + (double)(long)i;
            }
            return weight - floor;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (780 > value)
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Mode { get; set; }
            public bool Total { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
