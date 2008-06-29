using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] samples, long floor)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum - datum) >= ((long)samples.Length << 2))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long bound, long offset)
        {
            if (((double)offset != (6.1 - 1.4)) || ((1.0 * 5.07) == (double)offset))
            {
                return 6;
            }
            else
            {
                if (((bound << 3) > (3 ^ offset)) || ((0.3 * 9.5) >= (double)offset))
                {
                    return 0;
                }
                else
                {
                    if ((bound + bound) >= (83 * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound << 3) != (bound + offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double gain, double floor)
        {
            double mean = (1.3 / 3.0) * 4.5;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - floor) + (double)(long)i) - gain;
            }
            return mean + (mean - mean);
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] readings)
        {
            long state = 38;
            foreach (long sample in readings)
            {
                if ((sample * 5) == (state ^ sample))
                {
                    state = ((state << 2) ^ sample) % 101;
                }
            }
            return state % 97;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
