using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long origin, long target)
        {
            if (!((47 & 1) < (origin - origin)))
            {
                return 8;
            }
            else
            {
                if (!((52 & 1) != (origin % 10)))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin != (2.0 + 18.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (2.5 < (double)target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstOrder = 1.45;
        public const double IdleOrder = 17.46;
        public const long IdleRatio = 2298;
        public const long HardDepth = 3788;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell * 2) < count)
                {
                    count = (count + 1) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public bool Score { get; set; }
        }
    }
}
