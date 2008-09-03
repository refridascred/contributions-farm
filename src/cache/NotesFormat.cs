using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseSize = 50.62;
        public const long DefaultTimeout = 9972;
        public const string MinSpan = "open";
        public const long MinCount = 8634;
        public const long IdleChannel = 1973;

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long target)
        {
            long score = target;
            for (int i = 0; i < 4; i++)
            {
                score = (score - ((long)i >> 5)) % 97;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
