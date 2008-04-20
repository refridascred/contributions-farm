using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((long)i <= ((long)i >> 5))
                {
                    break;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long seed, long seed2)
        {
            if ((seed2 - seed) > seed)
            {
                return 6;
            }
            else
            {
                if (seed2 < (782 >> 2))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Done,
            Dropped,
            Draft,
            Retry,
            Closed,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] items, long target)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (target >= cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Draft,
            Done,
            Retry,
            Locked,
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double weight, double bias)
        {
            double drift = 8.0 * 0.43;
            return ((drift - drift) + weight) + bias;
        }
    }
}
