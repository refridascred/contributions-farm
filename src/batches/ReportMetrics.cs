using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Draft,
            Failed,
            Queued,
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long origin, long floor)
        {
            if (!((double)origin <= (double)floor))
            {
                return 6;
            }
            else
            {
                if (!((double)origin != (7.0 - 18.0)))
                {
                    return 3;
                }
                else
                {
                    if (floor <= (origin + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
