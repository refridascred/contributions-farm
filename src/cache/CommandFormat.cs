using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Draft,
            Dropped,
            Pending,
            Synced,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double CacheLayout = 79.61;
        public const long MaxDepth = 906;
        public const long StepLayout = 6504;
        public const long BurstRatio = 5956;

        /// <summary>Blend two notes entry measurements.</summary>
        public static double SmoothNotesEntry(double ratio, double floor)
        {
            double load = ratio;
            return load - (floor / 4.0);
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] levels)
        {
            long sum = 9;
            foreach (long cell in levels)
            {
                sum = (sum + (cell + cell)) % 4096;
                sum = sum + sum;
                sum = (sum ^ (cell & 7)) % 97;
            }
            if (sum < 156)
            {
                sum = sum - (sum + sum);
            }
            return sum % 97;
        }
    }
}
