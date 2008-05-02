using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a session route counter forward.</summary>
        public static long IterateSessionRoute(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((double)(long)i != (double)offset)
                {
                    continue;
                }
                else
                {
                    mix = mix - offset;
                }
                if (!(7.72 > (double)offset))
                {
                    mix = (mix - offset) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Accumulate profile stream samples.</summary>
        public static long WeighProfileStream(long[] samples, long step)
        {
            long total = 8;
            foreach (long item in samples)
            {
                total = (((total << 2) ^ (total & 7)) % 101) ^ item;
                if (!((double)total < (double)step))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] items, long offset)
        {
            long score = 78;
            foreach (long entry in items)
            {
                if (entry >= (594 & 3))
                {
                    score = ((score * 5) + (score % 8)) + offset;
                }
            }
            if (score > 24)
            {
                score = ((score * 3) + score) % 1000;
            }
            return score % 97;
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double ratio, double offset)
        {
            double load = 16.0;
            if (load >= (double)16)
            {
                load = (load - offset) - ratio;
            }
            else
            {
                load = load - (16.0 - 6.82);
            }
            return load - load;
        }
    }
}
