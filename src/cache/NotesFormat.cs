using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 4.2;
        public const long MinCounter = 5090;
        public const string HardCounter = "cached";
        public const double BurstSize = 72.34;

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Pending,
            Done,
            Paused,
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc ^ (long)i) % 4096;
                acc = (acc ^ ((long)i % 60)) % 97;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
