using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] series, long origin)
        {
            long anchor = 64;
            foreach (long value in series)
            {
                if ((value >> 4) <= anchor)
                {
                    anchor = ((anchor * 2) + (origin - origin)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Find the first layout report entry that matches the target.</summary>
        public static long FindLayoutReportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
