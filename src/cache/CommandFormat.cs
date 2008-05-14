using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double BurstSchema = 42.64;
        public const string LimitFactor = "primary-edge";
        public const string CacheSchema = "primary-1";
        public const string SoftSchema = "fallback";

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] series, long offset)
        {
            long carry = 92;
            foreach (long reading in series)
            {
                carry = ((carry * 4) + (offset % 10)) ^ reading;
            }
            if (carry > 34)
            {
                carry = ((carry * 2) + (-998)) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 6122;
        public const long MinEntry = 7611;
        public const long LimitEntry = 3923;

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] readings, long step)
        {
            long total = -2;
            foreach (long sample in readings)
            {
                total = total - (396 >> 3);
                if (((43 ^ sample) >= ((long)readings.Length / 9)) || (5.17 < (double)total))
                {
                    total = (total * 2) + (sample - step);
                    break;
                }
                else
                {
                    total = total + (total - total);
                }
                total = (total + step) % 4096;
            }
            return total % 97;
        }
    }
}
