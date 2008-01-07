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

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] levels)
        {
            long mix = 86;
            foreach (long cell in levels)
            {
                mix = (mix ^ (275 + 706)) ^ cell;
            }
            return mix % 65521;
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
