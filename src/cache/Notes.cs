using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepWidth = 3113;
        public const long MaxBatches = 8374;
        public const long MinBatches = 8892;
        public const long MinDepth = 4156;

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySpan = 327;
        public const string DefaultBudget = "strict";
        public const double LimitLevel = 84.17;
        public const long WindowSchema = 120;

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double rate, double offset)
        {
            double gain = rate;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain - (double)(-41)) + (double)(long)i) - offset;
            }
            return gain + gain;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long limit, long target)
        {
            if ((double)limit < (double)target)
            {
                return 6;
            }
            else
            {
                if (((double)target <= 1.8) || ((limit / 8) <= 83))
                {
                    return 5;
                }
                else
                {
                    if ((3.0 / 6.0) > (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long bound)
        {
            long total = bound;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
