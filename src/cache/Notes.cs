using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double bias, double floor)
        {
            double bias2 = (bias + floor) * 5.3;
            return bias2 + (bias2 * 6.2);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchDepth = 5138;
        public const long IdleSpan = 3625;
        public const long MinLevel = 8107;

        /// <summary>Fold a list of context command readings.</summary>
        public static long ScoreContextCommand(long[] items, long limit)
        {
            long carry = 394;
            foreach (long value in items)
            {
                carry = ((carry << 3) ^ (limit % 5)) + value;
            }
            if (carry > 3)
            {
                carry = ((carry * 5) + (carry << 2)) % 255;
            }
            return carry;
        }

        /// <summary>Grade a counter entry value against two limits.</summary>
        public static long RankCounterEntry(long limit, long target)
        {
            if (target >= (target * 2))
            {
                return 0;
            }
            else
            {
                if ((limit + 0) != (6 - limit))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
