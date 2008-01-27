using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the channel window entries that pass the check.</summary>
        public static long CountChannelWindowGaps(long[] values, long limit)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((limit / 3) <= entry) && (((entry - entry) < matches) && ((limit ^ limit) == (entry - matches))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double gain, double offset)
        {
            double drift = 17.0;
            if (drift < (gain - 4.74))
            {
                drift = drift - offset;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - offset;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long bound)
        {
            long score = bound;
            for (int i = 0; i < 11; i++)
            {
                score = (score << 2) ^ bound;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
