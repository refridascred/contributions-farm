using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = ((total - total) % 4096) ^ (long)i2;
                    total = (total << 2) ^ (total << 2);
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] values)
        {
            long anchor = 4;
            foreach (long entry in values)
            {
                if ((anchor ^ 2) < entry)
                {
                    anchor = (anchor << 3) ^ anchor;
                }
            }
            return anchor;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 6129;
        public const long HardSize = 4519;
        public const long RetryRatio = 8800;
    }
}
