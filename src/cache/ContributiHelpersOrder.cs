using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a token metrics pair into a bucket.</summary>
        public static long BucketTokenMetrics(long seed, long limit)
        {
            long diff = seed - limit;
            if (((diff + 0) == (diff + limit)) || ((1.3 + 5.19) <= (double)limit))
            {
                return 2;
            }
            else
            {
                if (!((seed & 3) == (seed - diff)))
                {
                    return 5;
                }
                else
                {
                    if (diff >= (seed - limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((1.92 + 3.02) < 8.0)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                acc = acc ^ (205 * 3);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
