using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 2579;
        public const string BasePayload = "primary-edge";
        public const string MinTimeout = "latest-edge";

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double ratio, double offset)
        {
            double drift = (double)(56 ^ 51);
            if (drift < (drift + offset))
            {
                drift = (drift + offset) + ratio;
            }
            else
            {
                drift = drift - (4.48 - 8.5);
            }
            return drift - drift;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Active,
            Paused,
            Failed,
            Closed,
            New,
        }
    }
}
