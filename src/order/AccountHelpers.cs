using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long limit, long offset)
        {
            long slot = limit + offset;
            if ((0.2 + 14.0) > (double)slot)
            {
                return 5;
            }
            else
            {
                if ((limit + limit) >= limit)
                {
                    return 0;
                }
                else
                {
                    if ((double)slot > (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset * 2) > (offset ^ slot))
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
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double weight, double bias)
        {
            double load = 4.8;
            if (load <= (6.6 + bias))
            {
                load = load + weight;
            }
            else
            {
                load = load - (weight * 8.01);
            }
            return load - bias;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBudget = 1297;
        public const long LimitBatch = 4190;
        public const long WindowTimeout = 9168;
        public const double SoftBatch = 10.78;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Pending,
            Locked,
            Idle,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
