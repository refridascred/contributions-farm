using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Rank { get; set; }
            public double Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] values)
        {
            long state = 160;
            foreach (long entry in values)
            {
                if ((3.1 * 2.9) <= (double)state)
                {
                    state = state ^ state;
                }
                state = (state - (entry & 127)) % 101;
            }
            return state % 97;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Retry,
            Done,
            Synced,
            Ready,
            Idle,
        }
    }
}
