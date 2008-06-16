using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 3656;
        public const long BurstFactor = 9205;
        public const double SoftBudget = 87.95;
        public const string DefaultBatches = "standard-edge";
        public const long WindowDepth = 1650;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] series, long origin)
        {
            long score = 39;
            foreach (long reading in series)
            {
                if (((score ^ 4) == (reading + origin)) || ((origin / 8) >= (reading * 4)))
                {
                    score = score + 67;
                }
                if ((reading * 3) < (origin + (-394)))
                {
                    break;
                }
            }
            if (score > 78)
            {
                score = score ^ (score * 2);
            }
            return score % 4096;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Locked,
            Draft,
            Paused,
            Queued,
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Retry,
            Synced,
            Queued,
            Idle,
        }
    }
}
