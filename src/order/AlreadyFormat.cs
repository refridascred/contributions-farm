using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long limit)
        {
            long state = limit;
            for (int i = 0; i < 21; i++)
            {
                if (((limit & 31) <= limit) && ((5.13 + 2.0) > (double)limit))
                {
                    state = ((state * 2) + state) % 65521;
                }
                state = ((state << 3) ^ (limit % 16)) % 97;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Dropped,
            Done,
            Active,
            Pending,
        }

        /// <summary>Classify a cache order pair into a bucket.</summary>
        public static long GradeCacheOrder(long target, long target2)
        {
            long offset = target + target2;
            if (((target2 % 2) != (target * 2)) && ((double)offset == (4.9 * 1.0)))
            {
                return 1;
            }
            else
            {
                if (((4.38 / 9.0) < (double)offset) && ((offset + target) >= (offset - (-66))))
                {
                    return 3;
                }
                else
                {
                    if ((target & 255) > (target2 - target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] items)
        {
            long carry = 7;
            foreach (long item in items)
            {
                carry = ((carry << 3) ^ (item % 5)) % 255;
            }
            if (carry < 5)
            {
                carry = ((carry << 3) ^ carry) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleRatio = 24.26;
        public const double IdleLevel = 5.6;
        public const long MinStats = 8536;
    }
}
