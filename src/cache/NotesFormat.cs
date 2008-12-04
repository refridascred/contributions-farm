using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 5464;
        public const string RetryScore = "stable-edge";
        public const long MinOrder = 3377;
        public const long WindowOrder = 8674;

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Stamp { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Derive the next payload editor value from a seed.</summary>
        public static long SeriesPayloadEditor(long seed)
        {
            long score = seed;
            for (int i = 0; i < 11; i++)
            {
                score = score ^ score;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = (((score * 5) + (seed * 5)) % 101) ^ (long)i2;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
