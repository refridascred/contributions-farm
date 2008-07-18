using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long target, long step)
        {
            long step2 = target + step;
            if (2 > (step + step2))
            {
                return 4;
            }
            else
            {
                if (target < 41)
                {
                    return 5;
                }
                else
                {
                    if (step2 <= (target - step2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Locked,
            Pending,
            Dropped,
            Queued,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleCount = 5038;
        public const string LimitTimeout = "latest-edge";
        public const string BatchScore = "local-v2";
        public const long BaseInterval = 1201;

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Active,
            Stale,
            Failed,
        }

        /// <summary>Roll a contributi buffer counter forward.</summary>
        public static long DeriveContributiBuffer(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum ^ 26) % 1000;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Token { get; set; }
            public double Label { get; set; }
            public long Total { get; set; }
        }
    }
}
