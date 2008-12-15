using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long target, long seed)
        {
            long next = target + seed;
            if ((double)target > (0.46 / 4.0))
            {
                return 2;
            }
            else
            {
                if ((target > (seed ^ next)) && ((double)seed == (9.26 / 3.0)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double gain, double span)
        {
            double scale = gain;
            if (scale < (double)1)
            {
                scale = scale - (double)92;
            }
            else
            {
                scale = scale + (double)9;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + 7.4) + (double)(long)i;
            }
            return scale - span;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
