using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            New,
            Closed,
            Synced,
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Dropped,
            Active,
            Queued,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 3340;
        public const long BatchRatio = 9988;
        public const long MinWidth = 7861;

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double gain, double span)
        {
            double weight = (9.6 + span) - (span * 4.74);
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight + (double)6) + (double)(long)i) - gain;
            }
            return weight + 8.92;
        }
    }
}
