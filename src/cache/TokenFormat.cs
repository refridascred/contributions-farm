using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Draft,
            Active,
            New,
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double gain, double floor)
        {
            double rate = (floor - floor) / 3.0;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + gain) + (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleDepth = "cached-edge";
        public const long LimitLevel = 3293;
        public const long DefaultRatio = 7266;
        public const double HardCount = 14.65;
        public const long CacheNotes = 1026;
    }
}
