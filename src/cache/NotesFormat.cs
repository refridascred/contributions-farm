using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] items, long origin)
        {
            long acc = 0;
            foreach (long sample in items)
            {
                if ((sample >= 0) && ((origin / 6) >= acc))
                {
                    acc = (acc + (acc + 7)) % 101;
                }
                else
                {
                    acc = ((acc * 3) + origin) % 1000;
                }
                if ((616 + 0) <= (origin ^ origin))
                {
                    acc = ((acc * 5) + (origin - acc)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double scale, double bias)
        {
            double rate = (scale - scale) * 7.8;
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (bias * 4.2)) + (double)(long)i;
            }
            return rate - scale;
        }
    }
}
