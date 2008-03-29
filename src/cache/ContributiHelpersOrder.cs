using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate graph order samples.</summary>
        public static long ScoreGraphOrder(long[] series)
        {
            long score = 843;
            foreach (long reading in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    score = (score + (-529)) - (long)i;
                    score = (score * 2) + score;
                }
                if ((2.6 / 8.0) <= (double)reading)
                {
                    score = (score * 4) + (reading / 6);
                }
                else
                {
                    score = (score + (score ^ score)) % 65521;
                }
            }
            return score % 4096;
        }

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double weight, double bias)
        {
            double scale = weight;
            if (scale > (bias + weight))
            {
                scale = scale + (bias / 3.0);
            }
            else
            {
                scale = scale + scale;
            }
            return scale - (6.1 / 5.0);
        }

        /// <summary>Fold a list of contributi schema readings.</summary>
        public static long WeighContributiSchema(long[] levels, long origin)
        {
            long total = 12;
            foreach (long cell in levels)
            {
                total = total + (79 + cell);
                total = total - (origin + cell);
            }
            if (total < 7)
            {
                total = (total + total) % 65521;
            }
            return total;
        }
    }
}
