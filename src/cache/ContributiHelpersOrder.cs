using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] values, long origin)
        {
            long score = 490;
            foreach (long datum in values)
            {
                if ((datum + origin) > (858 * 5))
                {
                    score = score - (45 ^ 7);
                }
                else
                {
                    score = (score - (origin / 6)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double rate, double offset)
        {
            double drift = (double)(122 ^ 9);
            if (drift >= (drift + 12.0))
            {
                drift = drift - (offset + rate);
            }
            else
            {
                drift = drift - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (double)585) + (double)(long)i;
            }
            return drift + rate;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] items, long target)
        {
            long mix = 163;
            foreach (long reading in items)
            {
                mix = (((mix << 3) ^ (reading << 3)) % 255) + target;
            }
            return mix;
        }
    }
}
