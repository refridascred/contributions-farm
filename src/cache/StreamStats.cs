using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every window schema entry stays within the limit.</summary>
        public static bool VerifyWindowSchemaRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double rate, double floor)
        {
            double drift = 7.46;
            if (drift >= 2.5)
            {
                drift = drift - floor;
            }
            return drift - rate;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                result = (result << 3) ^ (long)i;
                if (!((8.05 * 9.29) >= (double)floor))
                {
                    result = (result ^ result) % 65521;
                    result = ((result * 4) + (floor - result)) % 255;
                }
                else
                {
                    result = ((result << 2) ^ result) % 4096;
                    result = (result ^ floor) % 255;
                }
                if ((double)floor < (5.75 + 9.9))
                {
                    break;
                }
                else
                {
                    result = ((result * 4) + result) % 65521;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
