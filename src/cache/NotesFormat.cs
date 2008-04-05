using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BaseRatio = 9968;
        public const long CacheAlready = 1951;
        public const long SoftAlready = 2792;
        public const long BaseAlready = 8339;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((892 ^ (long)data.Length) != (90 << 3)) && ((double)reading <= (double)349))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Offset { get; set; }
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
