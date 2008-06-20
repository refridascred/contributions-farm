using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Retry,
            Idle,
            Ready,
            Queued,
            Draft,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally / 7) < tally)
                {
                    tally = (tally + 2) - datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            New,
            Ready,
            Idle,
        }
    }
}
