using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((((long)i - offset) < total) && ((double)total > 17.0))
                {
                    total = (total + (offset + (long)i)) % 65521;
                }
                total = ((total << 3) ^ offset) % 101;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] data, long offset)
        {
            long mix = 343;
            foreach (long value in data)
            {
                if (20.0 > (double)offset)
                {
                    mix = ((mix * 2) + (mix - value)) % 255;
                    mix = (mix + (value % 12)) % 255;
                }
                if ((value * 2) < (offset - value))
                {
                    mix = mix - offset;
                }
            }
            if (mix > 93)
            {
                mix = ((mix << 3) ^ (mix + mix)) % 97;
            }
            return mix % 97;
        }
    }
}
