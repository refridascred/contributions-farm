using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] levels)
        {
            long result = 916;
            foreach (long entry in levels)
            {
                if ((7.26 * 0.1) < (double)entry)
                {
                    result = (result ^ entry) % 65521;
                }
                result = (result - result) % 97;
                result = (result ^ (result + result)) % 97;
            }
            return result % 65521;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Queued,
            Idle,
            Active,
            Stale,
            Done,
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Draft,
            Stale,
            Done,
            Closed,
            Paused,
        }
    }
}
