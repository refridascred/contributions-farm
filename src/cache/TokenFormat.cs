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

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Done,
            New,
            Pending,
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
