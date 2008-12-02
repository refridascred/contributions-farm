using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 2224;
        public const long IdleScore = 5555;
        public const string BatchTimeout = "strict";

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen % 10) >= (entry >> 4))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }
    }
}
