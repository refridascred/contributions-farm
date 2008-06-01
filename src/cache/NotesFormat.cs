using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double scale, double floor)
        {
            double mean = 6.6 + (double)432;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean - mean) + (double)(long)i) + floor;
            }
            return mean - (scale * 8.2);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 2322;
        public const string StepWidth = "staging-edge";
        public const long DefaultSize = 6273;
        public const string BatchSize = "primary-1";

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            New,
            Stale,
            Closed,
            Active,
        }
    }
}
