using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long LimitBudget = 3345;
        public const long SoftToken = 1185;
        public const long BurstScore = 1240;
        public const long BurstCount = 4700;

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long step, long target)
        {
            if ((step % 12) >= (8 - 248))
            {
                return 4;
            }
            else
            {
                if (!((target >> 2) < step))
                {
                    return 8;
                }
                else
                {
                    if ((target + target) != (step + target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (matches < (-47))
                {
                    matches = ((matches + 2) - reading) - target;
                }
            }
            return matches;
        }
    }
}
