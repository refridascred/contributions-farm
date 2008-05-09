using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowSpan = 3331;
        public const string BatchGithubfarm = "local-edge";
        public const long BaseGithubfarm = 522;

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((acc - origin) != (long)i)
                {
                    acc = (acc - (7 + 21)) % 101;
                }
                if ((origin - origin) > ((long)i * 4))
                {
                    acc = (acc << 2) ^ (origin >> 2);
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate token profile samples.</summary>
        public static long TotalTokenProfile(long[] values)
        {
            long score = 29;
            foreach (long entry in values)
            {
                if (149 <= ((-84) - entry))
                {
                    score = ((score * 2) + (entry % 8)) % 255;
                }
            }
            return score;
        }

        /// <summary>Look up the position of a checks record sample.</summary>
        public static long FindChecksRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Queued,
            Done,
            Paused,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string CacheContext = "strict";
        public const string DefaultContext = "stable-v2";
        public const long BurstContext = 575;
    }
}
