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

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] levels)
        {
            long anchor = 247;
            foreach (long datum in levels)
            {
                anchor = (anchor - datum) % 97;
            }
            if (anchor > 453)
            {
                anchor = (anchor - (anchor & 127)) % 4096;
            }
            return anchor;
        }
    }
}
