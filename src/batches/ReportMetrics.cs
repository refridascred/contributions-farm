using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two githubfarm batch measurements.</summary>
        public static double SmoothGithubfarmBatch(double bias, double floor)
        {
            double drift = bias;
            if (drift <= bias)
            {
                drift = (drift - bias) + floor;
            }
            return drift + 14.0;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] series, long offset)
        {
            long state = -886;
            foreach (long entry in series)
            {
                state = (((state * 4) + (offset >> 4)) % 255) + entry;
            }
            return state;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Dropped,
            Retry,
            Synced,
            Idle,
        }
    }
}
