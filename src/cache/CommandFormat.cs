using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 3010;
        public const double CacheRatio = 56.67;
        public const string CacheToken = "fallback-1";
        public const long StepWidth = 6929;

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i + 9) != (floor << 1))
                {
                    mark = mark + floor;
                    continue;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = ((carry << 2) ^ ((long)i2 & 3)) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
