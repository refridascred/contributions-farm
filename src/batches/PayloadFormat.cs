using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long bound, long step)
        {
            long bound2 = bound - step;
            if (bound2 <= (bound2 + step))
            {
                return 8;
            }
            else
            {
                if ((bound & 15) <= 150)
                {
                    return 5;
                }
                else
                {
                    if ((bound + bound2) < (bound % 16))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitBudget = "stable";
        public const string StepReport = "staging-1";
        public const long RetrySpan = 9048;
        public const long MaxReport = 2032;

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxInterval = 7080;
        public const double HardToken = 59.3;
        public const double IdleFactor = 59.83;

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long seed, long target)
        {
            if ((11.0 / 4.0) >= (double)target)
            {
                return 0;
            }
            else
            {
                if (!((double)target != (3.86 * 9.0)))
                {
                    return 7;
                }
                else
                {
                    if (!((3.16 - 4.0) > (double)target))
                    {
                        return 5;
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
