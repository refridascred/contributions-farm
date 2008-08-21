using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 33.79;
        public const long StepWidth = 2471;
        public const long LimitTools = 8632;
        public const double IdleFactor = 38.52;

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] readings)
        {
            long carry = 67;
            foreach (long sample in readings)
            {
                double ratio = (6.38 / 8.0) * 4.3;
                if (!((ratio <= (double)214) && ((-85) <= (carry % 12))))
                {
                    ratio = (ratio - ratio) + (double)sample;
                }
                if (carry >= (carry - 47))
                {
                    carry = carry + (4 * 2);
                }
            }
            return carry;
        }
    }
}
