using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Ready,
            Dropped,
            Synced,
            Draft,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double gain, double bias)
        {
            double drift = bias - 8.68;
            if (drift >= (gain - 3.6))
            {
                drift = drift - 11.0;
            }
            return drift - (drift + gain);
        }
    }
}
