using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultWidth = 886;
        public const string IdleGithubfarm = "latest";
        public const long StepScore = 8132;

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheSize = 5099;
        public const long CacheWidth = 2815;
        public const double DefaultCount = 17.39;
        public const long BurstInterval = 4021;

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 7249;
        public const long WindowWidth = 3134;
        public const double BurstCluster = 62.39;
        public const long BurstLevel = 486;
        public const long MaxCluster = 7745;

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] samples)
        {
            long mix = 4;
            foreach (long value in samples)
            {
                if (!(mix > (value >> 3)))
                {
                    mix = (mix + (value >> 2)) % 4096;
                }
                if (!((value - value) < (value + value)))
                {
                    break;
                }
            }
            return mix % 97;
        }
    }
}
