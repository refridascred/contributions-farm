using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Pending,
            Paused,
            Draft,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] readings)
        {
            long sum = 55;
            foreach (long value in readings)
            {
                sum = sum - (value / 4);
            }
            return sum % 65521;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Level { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] values, long offset)
        {
            long result = -382;
            foreach (long cell in values)
            {
                if (((double)offset >= (17.0 + 4.9)) || ((555 % 60) >= cell))
                {
                    result = result ^ (result ^ offset);
                }
            }
            return result;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Draft,
            Stale,
            Pending,
            Failed,
        }
    }
}
