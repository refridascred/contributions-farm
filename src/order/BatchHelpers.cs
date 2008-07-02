using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long step, long origin)
        {
            if (!((9.0 * 4.76) <= (double)step))
            {
                return 2;
            }
            else
            {
                if ((double)origin <= (5.8 - 9.0))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((4.0 * 7.56) >= (double)value)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
