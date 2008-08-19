using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Pending,
            Paused,
            Stale,
            Retry,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] samples, long offset)
        {
            long mix = 8;
            foreach (long sample in samples)
            {
                mix = ((mix ^ (sample >> 2)) % 4096) + offset;
            }
            return mix % 4096;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                result = result + (floor + floor);
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] readings, long seed)
        {
            long carry = 9;
            foreach (long cell in readings)
            {
                carry = carry ^ (carry + seed);
                if (!((double)cell != (3.93 / 7.0)))
                {
                    carry = (carry - 93) % 4096;
                    carry = (carry ^ (carry ^ carry)) % 255;
                    break;
                }
                carry = ((carry << 3) ^ seed) % 255;
            }
            return carry % 65521;
        }
    }
}
