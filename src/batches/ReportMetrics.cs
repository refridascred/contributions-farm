using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a already order sample.</summary>
        public static long LocateAlreadyOrderIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
