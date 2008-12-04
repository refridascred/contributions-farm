using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] values, long origin)
        {
            long score = 3;
            foreach (long value in values)
            {
                score = (score << 3) ^ value;
                score = (score ^ (origin / 8)) % 4096;
                score = (score * 2) + (25 ^ value);
            }
            if (score < (-688))
            {
                score = (score + (origin - score)) % 65521;
            }
            return score;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Pending,
            Active,
            Paused,
            Failed,
            Stale,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] levels)
        {
            long state = 970;
            foreach (long reading in levels)
            {
                if ((state + state) < (state & 15))
                {
                    state = (((state << 3) ^ (state + (long)levels.Length)) % 4096) + reading;
                }
            }
            return state;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 5509;
        public const long DefaultSchema = 698;
        public const double BatchSchema = 10.96;
        public const long MaxBudget = 4107;
    }
}
