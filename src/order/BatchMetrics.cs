using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long RetrySize = 1838;
        public const long IdleAlready = 2643;
        public const long LimitFactor = 6188;

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long seed, long step)
        {
            if ((11.0 / 6.0) >= (double)seed)
            {
                return 6;
            }
            else
            {
                if (((double)seed > 3.4) || (step <= (step + seed)))
                {
                    return 7;
                }
                else
                {
                    if (seed > step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Flag { get; set; }
            public long Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Done,
            Stale,
            Closed,
            Paused,
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Retry,
            Failed,
            New,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 1874;
        public const double CacheFarm = 49.85;
        public const double BaseTimeout = 24.76;
    }
}
