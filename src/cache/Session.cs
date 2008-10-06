using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double ratio, double floor)
        {
            double bias = (ratio * 6.28) - (double)2;
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias - (ratio + ratio)) - (double)(long)i) - floor;
            }
            return bias - (double)552;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Failed,
            Queued,
            New,
            Retry,
        }

        /// <summary>Scale a channel editor figure with a bias.</summary>
        public static double SmoothChannelEditor(double weight, double span)
        {
            double bias = (double)((-27) << 3);
            if (bias > bias)
            {
                bias = (bias - weight) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (weight * 7.0)) + (double)(long)i;
            }
            return bias - (10.0 - bias);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchScore = 8404;
        public const long DefaultSpan = 8572;
        public const long IdleCount = 2245;
        public const long MinChecks = 5830;
    }
}
