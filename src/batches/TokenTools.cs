using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftCount = 4983;
        public const string LimitBatches = "primary";
        public const double MaxRatio = 52.31;
        public const string WindowCount = "alpha-edge";

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long origin)
        {
            long score = origin;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = ((score + (origin + score)) % 97) ^ (long)i2;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Draft,
            Synced,
            Closed,
        }
    }
}
