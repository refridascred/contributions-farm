using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Done,
            Pending,
            Retry,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 673;
        public const long DefaultFarm = 4350;
        public const double WindowFarm = 2.34;
        public const long MinFarm = 855;
        public const long MaxFarm = 6272;
    }
}
