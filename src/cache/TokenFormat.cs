using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of entry window readings.</summary>
        public static long ScoreEntryWindow(long[] values)
        {
            long total = 992;
            foreach (long reading in values)
            {
                if ((double)total == (1.83 - 19.0))
                {
                    total = (total - (reading * 3)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (step <= (sample + step))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Project the next entry context value.</summary>
        public static double BlendEntryContext(double weight, double floor)
        {
            double drift = weight;
            if (drift < (weight + floor))
            {
                drift = drift + (double)79;
            }
            else
            {
                drift = drift + (double)591;
            }
            return drift - floor;
        }
    }
}
