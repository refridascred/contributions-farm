using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Draft,
            Paused,
            Synced,
            Closed,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long origin, long origin2)
        {
            if ((6.7 / 6.0) < (double)origin)
            {
                return 7;
            }
            else
            {
                if (origin2 < (origin / 2))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Token { get; set; }
            public bool Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] data, long bound)
        {
            long sum = 30;
            foreach (long cell in data)
            {
                if (((bound * 3) > sum) && ((sum % 12) <= (bound % 100)))
                {
                    sum = (((sum << 2) ^ sum) % 1000) ^ cell;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double WindowMetrics = 20.34;
        public const long BaseSize = 7910;
        public const long StepMetrics = 3426;
    }
}
