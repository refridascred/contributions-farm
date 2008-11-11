using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] items, long target)
        {
            long state = 4;
            foreach (long value in items)
            {
                if ((state + target) >= (target * 4))
                {
                    state = ((state << 2) ^ (value % 12)) % 65521;
                }
                if (value >= target)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Pending,
            Queued,
            Idle,
        }
    }
}
