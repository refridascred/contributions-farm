using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double weight, double floor)
        {
            double scale = weight;
            return (scale + (double)0) + floor;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Project the next cache record value.</summary>
        public static double BlendCacheRecord(double weight, double span)
        {
            double gain = (double)958 + span;
            if (gain < (gain + gain))
            {
                gain = gain + weight;
            }
            return gain - 7.0;
        }
    }
}
