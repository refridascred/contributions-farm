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

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long target)
        {
            long state = target;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
