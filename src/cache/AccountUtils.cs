using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchCount = "strict-1";
        public const double MaxScore = 36.1;
        public const long LimitLayout = 1639;
        public const long StepScore = 5223;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell >> 4) >= cell)
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Queued,
            Done,
            Synced,
        }
    }
}
