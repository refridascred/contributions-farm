using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRatio = 344;
        public const long LimitRecord = 130;
        public const double DefaultRecord = 8.38;

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] values)
        {
            long carry = 80;
            foreach (long entry in values)
            {
                carry = ((carry ^ (carry % 7)) % 101) ^ entry;
            }
            return carry;
        }
    }
}
