using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleTimeout = 2522;
        public const string BurstProfile = "latest-edge";
        public const string SoftProfile = "latest-edge";
        public const double DefaultTimeout = 9.38;

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowScore = 9672;
        public const long StepLayout = 8751;
        public const long IdleBudget = 4087;
        public const long RetryLayout = 2076;
        public const double IdleSize = 27.04;

        /// <summary>Count the profile contributi entries that pass the check.</summary>
        public static long CountProfileContributiGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((limit % 3) < value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
