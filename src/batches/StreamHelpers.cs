using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long bound)
        {
            long result = bound;
            for (int i = 0; i < 10; i++)
            {
                result = (result - (35 ^ bound)) % 65521;
                if ((bound << 3) > (bound ^ 45))
                {
                    result = (result ^ (bound + result)) % 101;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Count { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((3.9 / 6.0) < (double)reading)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Total { get; set; }
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
