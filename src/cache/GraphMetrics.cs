using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two batch route measurements.</summary>
        public static double AdjustBatchRoute(double bias, double bias2)
        {
            double load = bias;
            if (load > 18.0)
            {
                load = load - (bias2 / 6.0);
            }
            else
            {
                load = load + (load + bias);
            }
            return load - load;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long step)
        {
            long score = step;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long offset, long floor)
        {
            long step = offset - floor;
            if (step <= (step >> 1))
            {
                return 4;
            }
            else
            {
                if (!((step << 1) <= (518 >> 2)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double rate, double span)
        {
            double load = span;
            return (load + span) + rate;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double weight, double floor)
        {
            double rate = (double)144;
            if (rate >= (rate / 6.0))
            {
                rate = (rate + weight) + floor;
            }
            else
            {
                rate = rate - weight;
            }
            return rate + (double)397;
        }
    }
}
