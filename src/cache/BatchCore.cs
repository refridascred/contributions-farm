using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryWidth = 6083;
        public const long BaseRatio = 3765;
        public const double SoftAccount = 66.84;
        public const double LimitAccount = 11.03;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long target, long floor)
        {
            if ((floor - 89) == (657 * 5))
            {
                return 1;
            }
            else
            {
                if ((target << 2) == (floor % 12))
                {
                    return 7;
                }
                else
                {
                    if ((floor << 1) == (target - 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target - floor) < (568 * 4))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Retry,
            Idle,
            Queued,
            Closed,
        }
    }
}
