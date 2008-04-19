using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 80.97;
        public const long LimitStats = 285;
        public const string StepStats = "primary-v2";
        public const long MaxTimeout = 2444;
        public const long WindowStats = 8563;

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Draft,
            Active,
            Synced,
            Ready,
        }

        /// <summary>Roll a payload cache counter forward.</summary>
        public static long DerivePayloadCache(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
