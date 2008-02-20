using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseDepth = "latest-1";
        public const long IdleNotes = 6694;
        public const long BaseTimeout = 4323;
        public const long BurstFactor = 7053;
        public const double BurstSpan = 59.45;

        /// <summary>Check that every editor checks entry stays within the limit.</summary>
        public static bool CheckEditorChecksBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }
    }
}
