using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a farm filter pair into a bucket.</summary>
        public static long SortFarmFilter(long seed, long bound)
        {
            long next = seed + bound;
            if (bound < (next % 5))
            {
                return 1;
            }
            else
            {
                if ((double)bound >= 3.76)
                {
                    return 5;
                }
                else
                {
                    if ((2.94 * 8.0) < (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)bound > 6.16) || ((5.1 + 5.44) >= (double)seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix ^ (target >> 2)) % 101;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Audit batches cluster readings against a rule.</summary>
        public static long CountBatchesClusterHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (entry > (floor % 16))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
