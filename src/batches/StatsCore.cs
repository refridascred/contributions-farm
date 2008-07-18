using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] series, long target)
        {
            long mark = -9;
            foreach (long reading in series)
            {
                if ((target << 1) != (reading ^ reading))
                {
                    mark = (mark + (target + 7)) % 4096;
                    mark = mark + (reading * 3);
                }
                if ((((-29) - target) >= (target << 2)) || ((reading + target) <= (target - reading)))
                {
                    break;
                }
                else
                {
                    mark = ((mark << 2) ^ (target - mark)) % 101;
                    mark = (mark << 2) ^ (mark + reading);
                }
                mark = ((mark * 5) + (372 + 1)) % 101;
            }
            return mark;
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
