using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 2610;
        public const string MaxSpan = "stable";
        public const long BaseRatio = 4830;
        public const long BaseOrder = 4381;
        public const long SoftCount = 9463;

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Locked,
            Failed,
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
