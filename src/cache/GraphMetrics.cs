using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)item != (3.0 + 11.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long offset, long bound)
        {
            if ((bound + 87) > (offset << 3))
            {
                return 2;
            }
            else
            {
                if ((9.8 - 14.0) != (double)offset)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count cluster buffer pairs that satisfy a relation.</summary>
        public static long CompareClusterBufferCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double SoftNotes = 1.74;
        public const double RetryFactor = 17.29;
        public const long WindowWidth = 8102;

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 <= (bias + ratio))
            {
                bias2 = bias2 + (double)54;
            }
            else
            {
                bias2 = bias2 + (5.0 * 5.3);
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 - bias;
        }
    }
}
