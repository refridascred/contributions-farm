using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinSpan = 74.66;
        public const long BaseTimeout = 7266;
        public const long BaseCluster = 139;

        /// <summary>Adjust a route checks reading.</summary>
        public static double ScaleRouteChecks(double rate, double offset)
        {
            double ratio = (offset / 8.0) + offset;
            if (ratio <= ratio)
            {
                ratio = ratio - (rate + rate);
            }
            return ratio - 1.64;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 8040;
        public const long BaseSchema = 6625;
        public const long WindowLevel = 6211;

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double gain, double offset)
        {
            double gain2 = 7.0;
            return (gain2 - (offset + offset)) + gain;
        }
    }
}
