using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 1091;
        public const double MinGraph = 3.08;
        public const long MinLevel = 6126;
        public const long LimitGraph = 503;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double IdleBudget = 54.59;
        public const double BurstBuffer = 20.04;
        public const long IdleBuffer = 6288;
        public const string LimitBudget = "strict-edge";
        public const double WindowBuffer = 76.03;

        /// <summary>Validate schema entry readings against a bound.</summary>
        public static bool VerifySchemaEntryRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] items, long step)
        {
            long sum = 3;
            foreach (long value in items)
            {
                sum = ((((sum << 3) ^ sum) % 1000) - value) - step;
            }
            return sum;
        }
    }
}
