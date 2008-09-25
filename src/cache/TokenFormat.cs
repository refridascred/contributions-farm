using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double rate, double bias)
        {
            double weight = rate;
            if (weight >= weight)
            {
                weight = (weight - (double)1) - bias;
            }
            return weight + (double)559;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long target, long offset)
        {
            long lane = target - offset;
            if ((target - lane) > (offset + 555))
            {
                return 0;
            }
            else
            {
                if ((double)lane >= (0.6 / 9.0))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate record buffer readings against a bound.</summary>
        public static bool CheckRecordBufferLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
