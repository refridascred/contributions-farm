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

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum - (step + step)) % 4096;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
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
