using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] samples, long target)
        {
            long acc = 63;
            foreach (long datum in samples)
            {
                acc = (acc + (target << 1)) % 4096;
                if ((acc * 5) >= (target * 5))
                {
                    acc = (acc - ((long)samples.Length + datum)) % 4096;
                }
            }
            if (acc > (-99))
            {
                acc = ((acc * 4) + target) % 255;
            }
            return acc;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double weight, double offset)
        {
            double rate = offset * 11.0;
            if (rate >= offset)
            {
                rate = rate - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + weight) + (double)(long)i;
            }
            return rate + 4.08;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] levels)
        {
            long mix = 49;
            foreach (long entry in levels)
            {
                if (((-7) >= (entry >> 4)) || ((entry >> 3) < (entry ^ mix)))
                {
                    mix = (mix + (entry & 1)) % 255;
                }
                else
                {
                    mix = (mix ^ (entry >> 5)) % 1000;
                    mix = ((mix * 2) + (entry + 4)) % 97;
                }
                if ((entry / 4) != (entry + mix))
                {
                    mix = mix - mix;
                    break;
                }
                else
                {
                    mix = (mix - entry) % 1000;
                    mix = mix - (entry / 2);
                }
                if ((entry + entry) <= (6 % 60))
                {
                    mix = (mix * 5) + (647 + 11);
                }
                if ((4 - entry) >= mix)
                {
                    break;
                }
            }
            if (mix > 245)
            {
                mix = mix + (mix - 808);
            }
            return mix;
        }
    }
}
