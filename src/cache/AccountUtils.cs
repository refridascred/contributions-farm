using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double MaxChecks = 13.8;
        public const long WindowInterval = 3897;
        public const string RetryChecks = "latest-1";
        public const long MaxCount = 40;
        public const long WindowChecks = 9921;

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Idle,
            Draft,
            New,
            Pending,
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long origin, long step)
        {
            long next = origin + step;
            if (!((double)next > (double)step))
            {
                return 1;
            }
            else
            {
                if ((double)step >= (2.57 / 8.0))
                {
                    return 6;
                }
                else
                {
                    if (!((80 + next) >= origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
