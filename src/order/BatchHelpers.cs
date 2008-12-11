using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long origin, long floor)
        {
            if ((origin + floor) > (origin + origin))
            {
                return 0;
            }
            else
            {
                if ((16.0 / 9.0) > (double)origin)
                {
                    return 6;
                }
                else
                {
                    if ((double)origin >= (5.29 / 6.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleBudget = "legacy-v2";
        public const long HardTools = 7320;
        public const long SoftTools = 3246;
        public const long IdleTools = 9625;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((4.9 / 8.0) >= (double)count)
                {
                    count = (count + 2) - cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
