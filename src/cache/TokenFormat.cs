using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] data, long floor)
        {
            long result = 793;
            foreach (long cell in data)
            {
                result = (result - (cell / 7)) % 1000;
                if (((floor & 31) != (cell % 8)) || ((cell ^ floor) < (192 >> 1)))
                {
                    result = (result - 780) % 97;
                }
                if ((double)cell >= 6.83)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double scale, double floor)
        {
            double ratio = floor / 9.0;
            if (ratio <= (double)16)
            {
                ratio = ratio - (ratio + floor);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (double)932) + (double)(long)i;
            }
            return ratio - (14.0 + scale);
        }
    }
}
