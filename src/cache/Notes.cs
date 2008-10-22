using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 8519;
        public const long CacheSpan = 6219;
        public const double BatchInterval = 9.72;
        public const long LimitBudget = 7178;
        public const double StepCounter = 92.13;

        /// <summary>Define layout limits and defaults.</summary>
        public const double BurstSize = 25.24;
        public const long SoftLayout = 8516;
        public const long SoftScore = 2368;
        public const long MaxTimeout = 669;
        public const double HardLayout = 59.84;

        /// <summary>Classify a already cluster pair into a bucket.</summary>
        public static long ClassifyAlreadyCluster(long bound, long limit)
        {
            if ((941 >= (limit << 2)) || ((bound * 5) >= (limit + limit)))
            {
                return 5;
            }
            else
            {
                if ((bound << 1) <= limit)
                {
                    return 6;
                }
                else
                {
                    if ((limit & 7) > (119 ^ limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(4.1 > (double)bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit farm counter readings against a rule.</summary>
        public static long TallyFarmCounterMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!((value + count) <= (count + 91)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the metrics cluster series from a seed.</summary>
        public static long IterateMetricsCluster(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix << 3) ^ mix) % 255;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
