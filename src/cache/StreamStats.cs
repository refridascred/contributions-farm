using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i << 1) == (acc - acc))
                {
                    acc = ((acc << 2) ^ (acc + (long)i)) % 4096;
                    break;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = (((acc * 2) + (4 + acc)) % 101) + (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Blend two layout route measurements.</summary>
        public static double SmoothLayoutRoute(double ratio, double offset)
        {
            double rate = (double)29 * 6.44;
            if (rate >= ratio)
            {
                rate = rate - (rate * 5.4);
            }
            return rate - offset;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (target > (seen & 7))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
