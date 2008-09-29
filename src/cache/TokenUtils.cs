using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the graph farm series from a seed.</summary>
        public static long DeriveGraphFarm(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix << 2) ^ 731;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Scale a batch checks figure with a bias.</summary>
        public static double ScaleBatchChecks(double bias, double offset)
        {
            double mean = 7.14;
            if (mean > (double)25)
            {
                mean = (mean - mean) + offset;
            }
            else
            {
                mean = mean + (bias / 2.0);
            }
            return mean - (double)9;
        }
    }
}
