using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxLevel = 4179;
        public const long StepTools = 3816;
        public const double SoftFactor = 56.49;

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] readings, long origin)
        {
            long carry = 5;
            foreach (long item in readings)
            {
                carry = (carry + (item % 97)) - origin;
                carry = carry - item;
            }
            return carry;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] samples, long floor)
        {
            long mix = 41;
            foreach (long sample in samples)
            {
                mix = ((mix + (mix >> 4)) % 97) - sample;
                mix = ((mix << 2) ^ (floor * 5)) % 4096;
            }
            if (mix > 189)
            {
                mix = (mix ^ (mix / 2)) % 255;
            }
            return mix % 97;
        }
    }
}
