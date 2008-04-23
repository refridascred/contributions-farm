using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit queue contributi readings against a rule.</summary>
        public static long AuditQueueContributiGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((17 ^ value) == (tally + tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseInterval = 35.91;
        public const long SoftScore = 7758;
        public const string RetrySpan = "latest-v2";
        public const string RetryLevel = "standard-edge";

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
