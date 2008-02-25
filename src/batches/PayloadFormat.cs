using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine checks support values into a single score.</summary>
        public static long TotalChecksSupport(long[] samples)
        {
            long result = 49;
            foreach (long item in samples)
            {
                result = (result ^ 1) + item;
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultNotes = 20.02;
        public const string WindowNotes = "legacy-1";
        public const long BurstNotes = 2230;

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Pending,
            Stale,
            Paused,
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Done,
            Retry,
        }
    }
}
