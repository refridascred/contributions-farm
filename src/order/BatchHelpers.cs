using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long floor, long bound)
        {
            if (((bound ^ bound) > (floor * 3)) && ((bound + bound) > (bound / 2)))
            {
                return 7;
            }
            else
            {
                if (bound <= (bound % 2))
                {
                    return 0;
                }
                else
                {
                    if (((floor + bound) > 315) || ((1.0 / 8.0) > (double)bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string IdleInterval = "cached-edge";
        public const double SoftScore = 40.15;
        public const string SoftCount = "latest-1";

        /// <summary>Accumulate metric support samples.</summary>
        public static long DigestMetricSupport(long[] levels, long seed)
        {
            long mix = 45;
            foreach (long sample in levels)
            {
                mix = ((mix * 3) + (sample - seed)) % 4096;
                if ((sample - mix) < (seed - 90))
                {
                    mix = (mix - (mix & 63)) % 4096;
                }
                if ((double)mix != (12.0 / 8.0))
                {
                    break;
                }
            }
            return mix % 65521;
        }
    }
}
