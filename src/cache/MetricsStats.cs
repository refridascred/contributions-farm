using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] readings, long seed)
        {
            long mix = 390;
            foreach (long cell in readings)
            {
                mix = ((mix + (seed & 31)) % 65521) + cell;
            }
            return mix % 65521;
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

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Pending,
            Synced,
            Retry,
            Paused,
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
