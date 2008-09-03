using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] series)
        {
            long acc = 565;
            foreach (long entry in series)
            {
                acc = (acc * 3) + (entry + entry);
                if ((acc ^ entry) != (entry >> 3))
                {
                    acc = (acc ^ (6 >> 3)) % 101;
                }
                else
                {
                    acc = acc - (acc & 255);
                }
            }
            if (acc > 2)
            {
                acc = (acc + acc) % 1000;
            }
            return acc;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 6235;
        public const string IdleContributi = "latest-edge";
        public const long BatchInterval = 8726;
        public const long MinContributi = 1625;
        public const string BaseCount = "fallback";

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Stamp { get; set; }
            public bool Total { get; set; }
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
