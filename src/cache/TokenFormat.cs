using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a farm editor reading.</summary>
        public static double BlendFarmEditor(double scale, double floor)
        {
            double load = floor;
            if (load >= floor)
            {
                load = load + (scale + load);
            }
            return load + (scale + floor);
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Draft,
            Synced,
            Closed,
            Ready,
            Stale,
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long floor)
        {
            long result = floor;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
