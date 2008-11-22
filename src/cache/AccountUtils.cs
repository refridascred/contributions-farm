using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Failed,
            Idle,
            Queued,
            Synced,
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Failed,
            Idle,
            Pending,
            Done,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)cell >= (1.2 * 5.78))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
