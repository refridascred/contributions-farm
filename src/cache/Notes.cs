using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next counter commits value from a seed.</summary>
        public static long StepCounterCommits(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 9; i++)
            {
                acc = acc + offset;
                acc = (acc * 4) + (acc - acc);
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowSize = 5849;
        public const long RetryLevel = 3874;
        public const double LimitCount = 0.4;
        public const long BurstFormat = 7990;
        public const long MaxFormat = 5530;

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            New,
            Closed,
            Pending,
            Failed,
            Active,
        }

        /// <summary>Rank checks channel input into a small class.</summary>
        public static long RankChecksChannel(long floor, long seed)
        {
            if ((seed % 5) <= (floor % 3))
            {
                return 6;
            }
            else
            {
                if (seed <= 95)
                {
                    return 3;
                }
                else
                {
                    if ((seed - floor) > floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
