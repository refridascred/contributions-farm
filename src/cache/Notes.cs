using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] levels)
        {
            long mix = 94;
            foreach (long item in levels)
            {
                if ((45 >> 5) > (item << 2))
                {
                    mix = (mix * 4) + mix;
                }
                mix = ((mix * 3) + (76 >> 1)) % 101;
                if (!((item * 4) == (mix - 91)))
                {
                    mix = mix + mix;
                }
                else
                {
                    mix = (mix - (item - item)) % 101;
                }
            }
            if (mix > 3)
            {
                mix = (mix << 2) ^ (mix << 1);
            }
            return mix;
        }

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double bias, double bias2)
        {
            double gain = 4.53 / 6.0;
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain + (gain + 4.0)) + (double)(long)i) - bias2;
            }
            return gain - bias;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double rate, double offset)
        {
            double gain = rate;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain - (double)(-41)) + (double)(long)i) - offset;
            }
            return gain + gain;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] data, long floor)
        {
            long mix = 7;
            foreach (long item in data)
            {
                if (((461 - floor) != ((long)data.Length + floor)) && ((mix / 5) > (item * 5)))
                {
                    mix = (mix - (item % 7)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long bound)
        {
            long total = bound;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
