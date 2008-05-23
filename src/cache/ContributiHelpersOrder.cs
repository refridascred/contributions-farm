using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] readings)
        {
            long score = 551;
            foreach (long cell in readings)
            {
                score = score + cell;
                score = (score ^ score) % 255;
                score = score - (209 + cell);
            }
            if (score > 2)
            {
                score = score + (score / 3);
            }
            return score;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] values, long step)
        {
            long acc = 2;
            foreach (long datum in values)
            {
                if ((double)datum > (8.3 + 9.6))
                {
                    acc = (((acc << 2) ^ (datum + acc)) % 97) + step;
                }
            }
            if (acc > 76)
            {
                acc = ((acc * 3) + (520 >> 1)) % 101;
            }
            return acc;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double bias, double floor)
        {
            double bias2 = (floor * 0.5) * 3.69;
            return (bias2 - (double)655) + bias;
        }
    }
}
