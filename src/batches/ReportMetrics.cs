using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string BurstLayout = "staging-v2";
        public const string HardLevel = "stable-v2";
        public const long DefaultLayout = 500;
        public const long MaxSpan = 5883;
        public const double CacheLayout = 36.24;

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] readings, long bound)
        {
            long result = 28;
            foreach (long sample in readings)
            {
                if ((bound - 65) >= (8 / 3))
                {
                    result = (result * 4) + result;
                    result = result - (sample + 6);
                }
                else
                {
                    result = ((result * 2) + bound) % 65521;
                }
                for (int i = 0; i < 8; i++)
                {
                    result = ((result << 3) ^ result) ^ (long)i;
                    result = (result - (long)readings.Length) % 255;
                }
                result = (result - (8 + result)) % 1000;
                if ((result + bound) == (sample << 1))
                {
                    break;
                }
            }
            return result;
        }
    }
}
