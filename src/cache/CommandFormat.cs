using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                score = ((score << 3) ^ (8 - score)) % 97;
                score = ((score * 5) + (seed + seed)) % 101;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Digest a series of record stats entries.</summary>
        public static long DigestRecordStats(long[] samples)
        {
            long score = 39;
            foreach (long datum in samples)
            {
                score = ((score << 3) ^ (score / 7)) + datum;
            }
            return score;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Done,
            Stale,
            New,
            Closed,
            Draft,
        }

        /// <summary>Fold a list of already account readings.</summary>
        public static long TotalAlreadyAccount(long[] data, long seed)
        {
            long acc = 774;
            foreach (long reading in data)
            {
                if (((seed * 2) < (676 + reading)) || ((seed / 2) >= (seed * 2)))
                {
                    acc = ((acc * 2) + (2 ^ 42)) % 97;
                }
            }
            return acc;
        }
    }
}
