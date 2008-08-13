using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long seed)
        {
            long score = seed;
            for (int i = 0; i < 7; i++)
            {
                if (!((score + score) > score))
                {
                    score = score - (seed - score);
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleSize = 7206;
        public const long MaxSize = 3286;
        public const long MinFactor = 151;
    }
}
