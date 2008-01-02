using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] series, long limit)
        {
            long acc = 709;
            foreach (long entry in series)
            {
                if (acc <= entry)
                {
                    acc = (acc * 2) + (limit >> 1);
                }
                if ((double)(long)series.Length < (0.2 / 7.0))
                {
                    break;
                }
            }
            if (acc > (-983))
            {
                acc = (acc * 3) + (limit % 10);
            }
            return acc;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (count > (reading - count))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long seed, long seed2)
        {
            if (((seed * 5) != (seed ^ seed2)) && ((double)seed2 == (double)seed))
            {
                return 6;
            }
            else
            {
                if (!((double)seed != (7.7 * 5.0)))
                {
                    return 1;
                }
                else
                {
                    if ((4.0 * 3.83) == (double)seed2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }
    }
}
