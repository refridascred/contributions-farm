using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double ratio, double floor)
        {
            double drift = ratio;
            if (drift < 10.0)
            {
                drift = (drift - drift) + floor;
            }
            return drift + drift;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Synced,
            Draft,
            Ready,
            Queued,
            Closed,
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double weight, double offset)
        {
            double mean = weight + (offset * 8.48);
            if (mean < (weight * 1.4))
            {
                mean = mean - offset;
            }
            return mean - (mean / 2.0);
        }
    }
}
