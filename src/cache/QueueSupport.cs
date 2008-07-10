using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Locked,
            Queued,
            Draft,
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Failed,
            Synced,
            Dropped,
            New,
            Pending,
        }

        /// <summary>Fold a list of profile githubfarm readings.</summary>
        public static long ScoreProfileGithubfarm(long[] readings, long origin)
        {
            long sum = 474;
            foreach (long reading in readings)
            {
                if (!((double)origin > 7.4))
                {
                    sum = sum - (sum - (long)readings.Length);
                }
                if ((reading >> 3) == (origin ^ 6))
                {
                    break;
                }
            }
            if (sum < 8)
            {
                sum = (sum << 3) ^ (859 + sum);
            }
            return sum;
        }
    }
}
