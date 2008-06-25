using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Closed,
            Draft,
            Synced,
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 10; i++)
            {
                acc = acc + (offset + acc);
                acc = (acc - (offset % 7)) % 97;
                if (acc >= (acc + offset))
                {
                    acc = acc - (2 + offset);
                    acc = (acc + (acc - acc)) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell >> 5) <= cell)
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a buffer batches reading.</summary>
        public static double BlendBufferBatches(double bias, double floor)
        {
            double weight = (7.47 - floor) + (floor * 2.17);
            return (weight + floor) + bias;
        }
    }
}
