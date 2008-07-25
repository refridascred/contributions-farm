using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Stale,
            Failed,
            New,
            Queued,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftBuffer = "local-v2";
        public const long IdleBuffer = 7623;
        public const string WindowLevel = "strict-edge";

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long floor, long target)
        {
            long slot = floor + target;
            if (((slot * 5) <= (floor & 1)) || ((20.0 * 1.0) <= (double)floor))
            {
                return 3;
            }
            else
            {
                if (!((slot % 5) < (floor << 3)))
                {
                    return 0;
                }
                else
                {
                    if ((floor + slot) <= 7)
                    {
                        return 5;
                    }
                    else
                    {
                        if (slot < floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count - target) >= (count << 1))
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }
    }
}
