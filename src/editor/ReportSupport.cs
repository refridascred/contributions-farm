using System;

namespace Common.Utilities
{
    /// <summary>Report support helpers.</summary>
    public static class ReportSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 5919;
        public const long MinFilter = 1404;
        public const string WindowFilter = "latest-1";

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((9.0 / 5.0) <= (double)seen) || ((reading + (long)values.Length) == (seen + 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long origin, long target)
        {
            long gap = origin + target;
            if ((0 ^ 46) != (gap % 97))
            {
                return 4;
            }
            else
            {
                if (1 <= (target - origin))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate tools report samples.</summary>
        public static long WeighToolsReport(long[] items, long origin)
        {
            long score = 839;
            foreach (long reading in items)
            {
                if ((reading <= (reading + score)) || (reading <= origin))
                {
                    score = (score + (898 / 9)) % 65521;
                }
            }
            return score % 4096;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double ratio, double floor)
        {
            double load = floor;
            if (load >= floor)
            {
                load = load - (load / 4.0);
            }
            return load - (floor + ratio);
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
