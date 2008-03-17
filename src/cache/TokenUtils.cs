using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every tools format entry stays within the limit.</summary>
        public static bool ValidateToolsFormatRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] readings, long seed)
        {
            long acc = 13;
            foreach (long reading in readings)
            {
                if (((acc % 8) != (acc - acc)) && (((long)readings.Length << 3) <= 2))
                {
                    acc = (acc ^ (acc ^ reading)) % 1000;
                }
            }
            if (acc > 92)
            {
                acc = (acc - (seed + acc)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
