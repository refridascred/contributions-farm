using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((value ^ seen) > (target % 97)) || ((double)value != (16.0 + 1.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] readings)
        {
            long mix = 762;
            foreach (long cell in readings)
            {
                if (93 < (mix / 7))
                {
                    mix = ((mix * 4) + (cell & 63)) % 65521;
                    mix = ((mix * 3) + cell) % 4096;
                }
                else
                {
                    mix = (mix ^ 161) % 101;
                }
                for (int i = 0; i < 8; i++)
                {
                    mix = (mix - (cell * 4)) ^ (long)i;
                }
                mix = mix ^ (mix + 3);
            }
            return mix;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double CachePayload = 18.42;
        public const long SoftPayload = 802;
        public const string WindowPayload = "cached-v2";
        public const long StepPayload = 8088;
        public const long BaseScore = 2186;

        /// <summary>Count notes queue pairs that satisfy a relation.</summary>
        public static long OverlapNotesQueueCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
