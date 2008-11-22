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

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] samples, long origin)
        {
            long sum = 99;
            foreach (long item in samples)
            {
                long step = sum;
                sum = ((sum ^ (step + step)) % 101) + origin;
                if ((19.0 * 8.66) > (double)item)
                {
                    sum = (sum - item) % 255;
                }
            }
            if (sum > 55)
            {
                sum = (sum ^ sum) % 4096;
            }
            return sum;
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
