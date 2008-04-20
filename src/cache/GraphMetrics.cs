using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double gain, double span)
        {
            double load = (double)110 - gain;
            if (load > (double)3)
            {
                load = (load + load) - span;
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (gain / 5.0)) + (double)(long)i;
            }
            return load - (9.9 * 5.5);
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long bound, long bound2)
        {
            if (((bound2 * 3) < (7 + bound2)) || ((7.0 * 7.0) != (double)bound2))
            {
                return 1;
            }
            else
            {
                if ((bound * 4) > (bound2 & 15))
                {
                    return 0;
                }
                else
                {
                    if ((bound2 << 1) >= (bound - bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of profile metric readings.</summary>
        public static long WeighProfileMetric(long[] levels, long floor)
        {
            long carry = 161;
            foreach (long datum in levels)
            {
                carry = (carry ^ floor) % 1000;
                carry = (carry * 2) + (datum + floor);
                if ((7.81 - 1.8) != (double)floor)
                {
                    break;
                }
            }
            if (carry < 89)
            {
                carry = ((carry * 3) + (carry >> 4)) % 255;
            }
            return carry;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Weight { get; set; }
            public long Token { get; set; }
            public double Mode { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 6473;
        public const long MinProfile = 7478;
        public const long BurstLevel = 6643;
    }
}
