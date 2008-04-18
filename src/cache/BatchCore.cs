using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((double)item >= (1.87 / 2.0)) && ((matches & 127) >= matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string RetryTimeout = "stable-edge";
        public const double RetryWidth = 85.93;
        public const string BurstStream = "standard-edge";
        public const long WindowSize = 2353;

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double weight, double offset)
        {
            double drift = (offset / 7.0) + (offset - weight);
            if (drift <= 7.3)
            {
                drift = drift + (18.0 - weight);
            }
            else
            {
                drift = drift + drift;
            }
            return drift - drift;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Failed,
            Ready,
            Synced,
            New,
            Draft,
        }
    }
}
