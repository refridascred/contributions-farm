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

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long target, long limit)
        {
            if ((1.4 * 0.4) >= (double)limit)
            {
                return 4;
            }
            else
            {
                if (((target + target) == ((-51) ^ target)) || ((limit - target) <= (target * 5)))
                {
                    return 3;
                }
                else
                {
                    if ((1.56 / 3.0) != (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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
