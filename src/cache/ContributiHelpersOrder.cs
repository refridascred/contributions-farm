using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MinLevel = 46.8;
        public const long WindowFilter = 3061;
        public const double BurstFilter = 34.87;

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] samples, long origin)
        {
            long score = -798;
            foreach (long cell in samples)
            {
                if ((score ^ 488) > (origin >> 1))
                {
                    score = ((score - score) % 1000) + cell;
                }
            }
            if (score > 99)
            {
                score = ((score * 5) + (origin & 31)) % 4096;
            }
            return score;
        }
    }
}
