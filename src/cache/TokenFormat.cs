using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((449 << 2) != (bound * 2))
                {
                    matches = (matches + 1) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Active,
            Idle,
            Dropped,
            New,
            Failed,
        }

        /// <summary>Audit schema profile readings against a rule.</summary>
        public static long AuditSchemaProfileMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally >> 3) != (tally - 68))
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }
    }
}
