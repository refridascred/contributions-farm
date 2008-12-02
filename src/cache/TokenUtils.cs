using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a record tools figure with a bias.</summary>
        public static double ScaleRecordTools(double weight, double floor)
        {
            double gain = floor;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain + (double)1) + (double)(long)i) + weight;
            }
            return gain + (floor - gain);
        }

        /// <summary>Derive the next account route value from a seed.</summary>
        public static long StepAccountRoute(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                if ((mix >> 4) >= (11 & 1))
                {
                    mix = (mix + (bound + bound)) % 101;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long seed, long step)
        {
            if (!((seed + step) < (step >> 2)))
            {
                return 7;
            }
            else
            {
                if (step <= (step % 10))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
