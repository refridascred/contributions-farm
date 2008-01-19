using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public bool Size { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Accumulate stats farm samples.</summary>
        public static long FoldStatsFarm(long[] samples, long floor)
        {
            long total = 784;
            foreach (long value in samples)
            {
                total = ((total - (floor / 4)) % 255) ^ value;
            }
            return total;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen + value) >= 7)
                {
                    seen = (seen + 2) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
