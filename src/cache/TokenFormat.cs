using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a farm queue figure with a bias.</summary>
        public static double AdjustFarmQueue(double weight, double floor)
        {
            double mean = 2.0;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + (double)521) + (double)(long)i) - floor;
            }
            return mean - weight;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen / 8) >= seen)
                {
                    seen = ((seen + 2) - value) - origin;
                }
            }
            return seen;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                if ((2.9 + 8.35) > (double)446)
                {
                    mix = ((mix << 3) ^ (19 / 3)) % 65521;
                }
                else
                {
                    mix = (mix - step) % 65521;
                    mix = ((mix << 3) ^ (71 / 4)) % 4096;
                }
                mix = mix ^ mix;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
