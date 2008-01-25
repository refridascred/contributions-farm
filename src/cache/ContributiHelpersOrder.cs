using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long target)
        {
            long mark = target;
            for (int i = 0; i < 19; i++)
            {
                mark = (mark * 3) + target;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Roll a commits contributi counter forward.</summary>
        public static long StepCommitsContributi(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                result = ((result << 2) ^ (seed + seed)) % 97;
                if (((seed ^ seed) <= (1 >> 5)) && ((89 + 314) <= (seed << 2)))
                {
                    result = (result + seed) % 255;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
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
