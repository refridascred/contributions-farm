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

        /// <summary>Look up the position of a notes entry sample.</summary>
        public static long LocateNotesEntryIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
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
