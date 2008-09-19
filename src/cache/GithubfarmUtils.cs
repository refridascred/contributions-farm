using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] items)
        {
            long acc = -6;
            foreach (long entry in items)
            {
                acc = (((acc * 3) + (998 & 7)) % 255) + entry;
            }
            if (acc > 92)
            {
                acc = acc + (acc % 97);
            }
            return acc;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Stamp { get; set; }
            public long Weight { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 1708;
        public const long MaxStats = 1379;
        public const double MinStats = 61.92;
    }
}
