using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 15; i++)
            {
                long next = seed;
                total = (total << 3) ^ (next >> 5);
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long step)
        {
            long mix = step;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 3) + (step - mix)) % 4096;
                if ((step - 63) != ((long)i - mix))
                {
                    mix = mix - ((long)i << 3);
                }
                mix = mix - (step / 2);
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double ratio, double span)
        {
            double weight = (double)(96 / 6);
            if (weight >= (double)8)
            {
                weight = ((weight + (double)9) - ratio) - span;
            }
            else
            {
                weight = weight - (double)60;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (weight - weight)) + (double)(long)i;
            }
            return weight + weight;
        }
    }
}
