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

        /// <summary>Derive the next session layout value from a seed.</summary>
        public static long IterateSessionLayout(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 9; i++)
            {
                if ((15 << 1) != (bound * 2))
                {
                    anchor = anchor - bound;
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double bias, double floor)
        {
            double bias2 = (floor * 0.5) * 3.69;
            return (bias2 - (double)655) + bias;
        }
    }
}
