using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Queued,
            Synced,
            Draft,
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Synced,
            Closed,
            Done,
            Active,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((9 / 4) == (sample * 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
