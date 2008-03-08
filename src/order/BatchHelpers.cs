using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Closed,
            Pending,
            Paused,
            Queued,
            Stale,
        }

        /// <summary>Scale a order entry figure with a bias.</summary>
        public static double ScaleOrderEntry(double scale, double floor)
        {
            double mean = scale;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean + (scale / 3.0)) - (double)(long)i) + floor;
            }
            return mean + (scale + scale);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinPayload = 20.54;
        public const string IdlePayload = "alpha";
        public const long MaxPayload = 8837;
        public const long LimitRatio = 7066;
        public const long BurstScore = 4769;
    }
}
