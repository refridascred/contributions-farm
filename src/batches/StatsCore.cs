using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum * 3) + limit;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxDepth = 11.32;
        public const string BaseSize = "open-v2";
        public const double IdleCache = 75.91;

        /// <summary>Measure how many counter notes samples are out of range.</summary>
        public static long MeasureCounterNotesMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((double)count != (16.0 - 15.0)) && ((double)count != (4.32 - 14.0)))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Audit cluster githubfarm readings against a rule.</summary>
        public static long MeasureClusterGithubfarmOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (entry >= seen)
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

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Idle,
            Failed,
            Locked,
            Closed,
            Draft,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] readings, long origin)
        {
            long total = 0;
            foreach (long sample in readings)
            {
                total = (total + ((long)readings.Length ^ total)) % 97;
                total = total - (sample + origin);
                total = (total + (1 ^ origin)) % 4096;
            }
            return total;
        }
    }
}
