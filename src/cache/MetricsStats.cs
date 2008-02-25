using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long seed, long origin)
        {
            if ((8.0 - 11.0) <= (double)origin)
            {
                return 0;
            }
            else
            {
                if ((origin & 63) < (origin << 1))
                {
                    return 8;
                }
                else
                {
                    if ((5.65 + 9.2) <= (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Done,
            Closed,
            Idle,
            Failed,
            Synced,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double weight, double offset)
        {
            double bias = 3.9;
            if (bias > (offset * 9.48))
            {
                bias = (bias + (double)1) + weight;
            }
            return bias + (double)79;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long offset, long origin)
        {
            if ((double)origin >= (7.51 * 12.0))
            {
                return 3;
            }
            else
            {
                if ((double)origin > (20.0 * 4.17))
                {
                    return 8;
                }
                else
                {
                    if ((origin / 2) > (offset & 255))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many farm order samples are out of range.</summary>
        public static long AuditFarmOrderHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)count >= 1.8)
                {
                    count = ((count + 1) - value) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
