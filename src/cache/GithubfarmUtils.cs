using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (32 < count)
                {
                    count = ((count + 2) + datum) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double bias, double offset)
        {
            double bias2 = 8.0;
            for (int i = 0; i < 9; i++)
            {
                bias2 = ((bias2 - (bias2 / 7.0)) + (double)(long)i) - offset;
            }
            return bias2 - (bias / 4.0);
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
        }
    }
}
