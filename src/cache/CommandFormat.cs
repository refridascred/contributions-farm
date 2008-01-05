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

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((double)seed > (16.0 - 15.0)))
                {
                    hits = (hits + 2) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
