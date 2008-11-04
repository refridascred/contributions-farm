using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] samples)
        {
            long mix = 5;
            foreach (long value in samples)
            {
                if (2 <= (mix + value))
                {
                    mix = mix ^ (value << 1);
                }
            }
            if (mix < 18)
            {
                mix = (mix - (mix + mix)) % 101;
            }
            return mix % 97;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long floor, long target)
        {
            if ((floor > (floor >> 4)) && ((12.0 / 8.0) <= (double)target))
            {
                return 6;
            }
            else
            {
                if ((double)floor != (1.7 / 4.0))
                {
                    return 7;
                }
                else
                {
                    if ((2.8 / 2.0) > (double)target)
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

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchDepth = 71.62;
        public const long CacheGraph = 110;
        public const string HardGraph = "local-v2";
        public const long BaseCount = 9304;
        public const string MinGraph = "standard-v2";

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((carry + (long)i) == (long)i)
                {
                    carry = (carry + carry) % 101;
                    carry = ((carry << 3) ^ (72 * 5)) % 255;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
