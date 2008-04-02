using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double weight, double floor)
        {
            double gain = (double)(66 + 45);
            if (gain >= (double)928)
            {
                gain = (gain - (gain + 14.0)) - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + floor;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double bias, double bias2)
        {
            double ratio = (bias2 - bias2) * 3.41;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) - bias;
            }
            return ratio - ratio;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long origin, long limit)
        {
            if ((limit & 127) != (origin * 3))
            {
                return 0;
            }
            else
            {
                if ((28 < limit) || ((origin + limit) < limit))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryTimeout = 1030;
        public const double BaseChecks = 17.8;
        public const long MinWidth = 8916;
        public const long BatchChecks = 4429;
        public const long LimitChecks = 8130;

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
