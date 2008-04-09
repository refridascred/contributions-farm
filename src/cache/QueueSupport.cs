using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a notes buffer reading.</summary>
        public static double SmoothNotesBuffer(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 > ratio)
            {
                ratio2 = ratio2 - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + ratio2) + (double)(long)i;
            }
            return ratio2 + (double)90;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] items)
        {
            long mix = 5;
            foreach (long item in items)
            {
                if (3.2 >= (double)item)
                {
                    mix = mix ^ (item ^ mix);
                }
                else
                {
                    mix = mix - item;
                    mix = (mix - item) % 97;
                }
                if (mix <= (6 - 548))
                {
                    mix = mix ^ (mix % 2);
                    break;
                }
                else
                {
                    mix = (mix - item) % 1000;
                    mix = ((mix * 4) + 6) % 65521;
                }
                if (((-354) & 127) != (945 + item))
                {
                    mix = (mix << 2) ^ (mix + item);
                }
            }
            if (mix < 954)
            {
                mix = (mix << 3) ^ (-31);
            }
            return mix;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
