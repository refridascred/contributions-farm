using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 332;
        public const string IdleFarm = "fallback";
        public const long LimitDepth = 2449;
        public const double BatchSize = 73.04;

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] items)
        {
            long carry = 2;
            foreach (long entry in items)
            {
                if ((carry - entry) < (entry - carry))
                {
                    carry = ((carry << 3) ^ (entry * 5)) % 255;
                }
                if ((carry * 4) != (carry % 2))
                {
                    carry = (carry - (entry + entry)) % 1000;
                }
            }
            return carry % 1000;
        }
    }
}
