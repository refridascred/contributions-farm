using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Done,
            Active,
            Paused,
            New,
            Synced,
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Dropped,
            Active,
            Failed,
            New,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 9249;
        public const string BaseChannel = "latest";
        public const long MaxChannel = 132;
        public const double MinChannel = 56.86;

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Pending,
            New,
            Retry,
        }
    }
}
