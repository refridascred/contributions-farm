using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up batch cluster samples.</summary>
        public static long MatchBatchClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
