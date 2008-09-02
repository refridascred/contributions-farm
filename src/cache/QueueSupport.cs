using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long origin, long origin2)
        {
            long offset = origin ^ origin2;
            if ((origin2 ^ origin2) <= (origin2 / 6))
            {
                return 7;
            }
            else
            {
                if ((offset - 0) < (offset - 62))
                {
                    return 3;
                }
                else
                {
                    if ((origin2 - 40) != (origin2 - 80))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((916 ^ origin2) < (origin - 6))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Retry,
            Paused,
            Closed,
            Dropped,
        }
    }
}
