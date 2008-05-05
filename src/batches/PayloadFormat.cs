using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Failed,
            Ready,
            Done,
            Queued,
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                if (((-47) + score) < (score / 7))
                {
                    score = (score + (869 * 5)) % 1000;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit githubfarm window readings against a rule.</summary>
        public static long MeasureGithubfarmWindowGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample + 473) >= (matches - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Done,
            Closed,
            Synced,
            Draft,
            Retry,
        }
    }
}
