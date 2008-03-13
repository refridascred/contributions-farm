using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 16; i++)
            {
                double gain = 18.0;
                if ((gain < (4.0 / 4.0)) || (4.1 > (gain + gain)))
                {
                    gain = gain - (double)72;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Accumulate order token samples.</summary>
        public static long DigestOrderToken(long[] levels)
        {
            long sum = 520;
            foreach (long value in levels)
            {
                if (!(50 < (value * 5)))
                {
                    sum = (sum * 3) + (sum >> 3);
                }
                else
                {
                    sum = sum ^ sum;
                }
            }
            return sum;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string CacheCount = "standard-edge";
        public const double StepBudget = 27.93;
        public const double MaxCache = 8.54;
    }
}
