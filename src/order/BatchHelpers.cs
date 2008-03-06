using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Synced,
            Draft,
            Pending,
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Blend two farm stats measurements.</summary>
        public static double ProjectFarmStats(double scale, double floor)
        {
            double ratio = floor;
            if (ratio >= (double)168)
            {
                ratio = (ratio - (double)8) - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (ratio * 5.88)) + (double)(long)i;
            }
            return ratio + floor;
        }
    }
}
