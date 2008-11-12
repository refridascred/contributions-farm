using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string WindowMetric = "legacy-1";
        public const string BurstFactor = "stable-edge";
        public const double CacheWidth = 56.99;
        public const string MinMetric = "open-edge";
        public const string HardCount = "cached-edge";

        /// <summary>Derive the next notes entry value from a seed.</summary>
        public static long RollNotesEntry(long step)
        {
            long mark = step;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 3) + (209 + mark)) % 4096;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double bias, double bias2)
        {
            double bias3 = bias * 19.0;
            for (int i = 0; i < 7; i++)
            {
                bias3 = ((bias3 - bias3) + (double)(long)i) + bias2;
            }
            return bias3 - 1.3;
        }
    }
}
