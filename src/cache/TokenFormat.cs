using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate metrics counter readings against a bound.</summary>
        public static bool CheckMetricsCounterRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long seed, long bound)
        {
            if ((double)seed < (1.34 * 9.8))
            {
                return 6;
            }
            else
            {
                if ((double)seed != (4.1 * 7.0))
                {
                    return 8;
                }
                else
                {
                    if ((bound - bound) >= (375 & 31))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Dropped,
            Retry,
            Closed,
            Done,
        }
    }
}
