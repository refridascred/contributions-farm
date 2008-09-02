using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count >> 5) > entry)
                {
                    count = (count + 3) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 1837;
        public const string WindowCounter = "stable";
        public const long BurstCounter = 8735;
        public const double RetryCounter = 75.71;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Retry,
            Dropped,
            Ready,
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long offset, long target)
        {
            if (1.94 >= (double)target)
            {
                return 7;
            }
            else
            {
                if ((target ^ offset) < (target - 1))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset != (1.8 + 7.1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset < (target ^ target)) || ((-141) > target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
