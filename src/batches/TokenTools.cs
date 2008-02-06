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

        /// <summary>Derive the next batch route value from a seed.</summary>
        public static long StepBatchRoute(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                if (!((13.0 - 8.7) != (double)(long)i))
                {
                    anchor = anchor - ((long)i >> 1);
                }
                anchor = (anchor ^ ((long)i << 1)) % 101;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Owner { get; set; }
            public bool Label { get; set; }
        }
    }
}
