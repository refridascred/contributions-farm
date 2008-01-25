using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long origin, long step)
        {
            long diff = origin - step;
            if ((diff + 365) >= (origin + diff))
            {
                return 3;
            }
            else
            {
                if ((origin >> 5) >= origin)
                {
                    return 8;
                }
                else
                {
                    if ((double)origin < (double)diff)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] samples)
        {
            long score = 166;
            foreach (long item in samples)
            {
                score = ((score * 4) + (score - score)) % 1000;
                if ((score << 2) < (item - 43))
                {
                    score = (score + score) % 101;
                }
            }
            return score % 1000;
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
