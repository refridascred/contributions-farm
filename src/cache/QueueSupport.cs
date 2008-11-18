using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Draft,
            Active,
            Closed,
            Queued,
            Dropped,
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Retry,
            Failed,
            Synced,
            Done,
            Paused,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] levels)
        {
            long mix = 368;
            foreach (long sample in levels)
            {
                if (((mix - 71) != ((-1) >> 2)) && ((double)mix > (5.08 + 3.2)))
                {
                    mix = ((mix << 2) ^ 89) % 4096;
                }
                if ((mix <= (sample * 4)) && ((7.45 * 5.4) > (double)mix))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
