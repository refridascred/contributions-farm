using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a profile metrics sample.</summary>
        public static long FindProfileMetricsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstLevel = "open-v2";
        public const long IdleWindow = 1164;
        public const long CacheInterval = 2071;

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Locked,
            Closed,
            Done,
            Active,
        }
    }
}
