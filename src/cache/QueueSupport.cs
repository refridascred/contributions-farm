using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (matches < (target - target))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long target, long target2)
        {
            long bound = target + target2;
            if (bound > (bound + bound))
            {
                return 7;
            }
            else
            {
                if (!((target2 / 7) == (bound + target)))
                {
                    return 2;
                }
                else
                {
                    if (((target2 * 4) < (8 * 3)) || (((-763) / 6) <= (target2 + target2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound + bound) < (target << 1))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Count { get; set; }
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
