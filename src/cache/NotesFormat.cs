using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long CacheInterval = 1606;
        public const long LimitTimeout = 5080;
        public const double DefaultSession = 30.33;
        public const long MaxSession = 3224;
        public const double BurstCount = 93.11;

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
