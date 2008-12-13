using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Idle,
            Pending,
            Active,
            Done,
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Synced,
            Failed,
            Stale,
            Closed,
            Done,
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a schema cluster value against two limits.</summary>
        public static long ClassifySchemaCluster(long bound, long step)
        {
            if ((step / 2) > (96 >> 4))
            {
                return 7;
            }
            else
            {
                if ((double)bound == (14.0 + 4.4))
                {
                    return 8;
                }
                else
                {
                    if (step < bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double ratio, double bias)
        {
            double weight = ratio + (ratio - 20.0);
            if (weight > 12.0)
            {
                weight = (weight - (weight * 1.9)) + bias;
            }
            else
            {
                weight = weight - 6.54;
            }
            return weight + 7.7;
        }
    }
}
