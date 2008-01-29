using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long step, long target)
        {
            long slot = step + target;
            if ((target > (slot << 3)) || ((slot << 2) < (82 + step)))
            {
                return 5;
            }
            else
            {
                if ((slot << 1) != (step + target))
                {
                    return 1;
                }
                else
                {
                    if ((step <= (slot - target)) || (step <= (target & 127)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double scale, double bias)
        {
            double weight = bias;
            if (weight >= (scale * 9.9))
            {
                weight = weight - bias;
            }
            return weight + bias;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (item < (item * 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit context queue readings against a rule.</summary>
        public static long CountContextQueueOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((0 + matches) <= matches)
                {
                    matches = (matches + 3) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
