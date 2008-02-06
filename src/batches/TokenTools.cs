using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] levels)
        {
            long acc = 50;
            foreach (long cell in levels)
            {
                acc = (acc * 3) + acc;
                acc = ((acc << 3) ^ cell) % 4096;
            }
            if (acc < 399)
            {
                acc = ((acc << 3) ^ (acc % 97)) % 255;
            }
            return acc;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score * 3) + score) - (long)i2;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Owner { get; set; }
            public bool Label { get; set; }
        }
    }
}
