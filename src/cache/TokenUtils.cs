using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] samples, long offset)
        {
            long mix = 60;
            foreach (long sample in samples)
            {
                mix = ((mix * 4) + (mix >> 2)) % 65521;
                if (!((mix % 7) != (sample << 1)))
                {
                    mix = (mix - (offset - offset)) % 65521;
                    continue;
                }
                if ((offset << 3) <= (mix & 255))
                {
                    mix = mix - (offset << 2);
                }
            }
            return mix % 1000;
        }
    }
}
