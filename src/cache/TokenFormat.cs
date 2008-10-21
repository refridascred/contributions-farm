using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                result = result - (299 - (long)i);
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
