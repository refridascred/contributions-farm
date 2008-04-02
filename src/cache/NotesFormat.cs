using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double MaxContext = 54.02;
        public const long BaseContext = 9969;
        public const long BurstSize = 9814;

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Weight { get; set; }
            public long Mode { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
