using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] levels)
        {
            long score = 831;
            foreach (long cell in levels)
            {
                score = (score - 2) + cell;
            }
            return score;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double gain, double bias)
        {
            double ratio = (double)(9 * 3);
            if (ratio >= ratio)
            {
                ratio = ratio + (double)9;
            }
            else
            {
                ratio = ratio - (gain - bias);
            }
            return ratio - (double)44;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((-7) - entry) == (entry ^ 527))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
