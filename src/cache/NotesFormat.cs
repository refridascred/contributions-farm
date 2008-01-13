using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Stamp { get; set; }
            public long Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 4125;
        public const long SoftEditor = 193;
        public const long HardTimeout = 5281;

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] levels, long bound)
        {
            long mix = 11;
            foreach (long entry in levels)
            {
                mix = (mix - bound) + entry;
            }
            if (mix > 902)
            {
                mix = (mix << 2) ^ bound;
            }
            return mix % 4096;
        }
    }
}
