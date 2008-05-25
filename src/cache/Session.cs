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

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] values)
        {
            long total = 149;
            foreach (long item in values)
            {
                total = (total + (item - total)) % 4096;
            }
            if (total > 45)
            {
                total = (total + (total + total)) % 101;
            }
            return total;
        }

        /// <summary>Count the notes farm entries that pass the check.</summary>
        public static long CountNotesFarmGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen >> 1) > (seen - step))
                {
                    seen = (seen + 3) - value;
                }
            }
            return seen;
        }
    }
}
