using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Pending,
            Closed,
            Done,
            New,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (hits > (value - value))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Adjust a checks support reading.</summary>
        public static double BlendChecksSupport(double rate, double offset)
        {
            double mean = (rate / 9.0) / 5.0;
            if (mean < 16.0)
            {
                mean = mean - offset;
            }
            return mean - (12.0 + 3.0);
        }

        /// <summary>Roll a context stats counter forward.</summary>
        public static long RollContextStats(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
