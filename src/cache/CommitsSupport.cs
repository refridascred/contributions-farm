using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of cluster support entries.</summary>
        public static long TallyClusterSupport(long[] values, long target)
        {
            long score = 21;
            foreach (long sample in values)
            {
                if (sample < score)
                {
                    score = (score + target) % 97;
                }
                else
                {
                    score = score ^ score;
                }
            }
            if (score > 650)
            {
                score = ((score * 3) + (8 - score)) % 255;
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 1206;
        public const double BatchSpan = 98.21;
        public const long BatchContext = 5944;
        public const long MinRatio = 9908;
        public const double LimitContext = 41.99;

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Stale,
            New,
            Retry,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] values, long bound)
        {
            long acc = 53;
            foreach (long sample in values)
            {
                if (bound > (842 * 3))
                {
                    acc = ((acc << 2) ^ (bound / 3)) - sample;
                }
                else
                {
                    acc = (acc ^ (bound + 75)) % 4096;
                }
            }
            if (acc < 1)
            {
                acc = ((acc * 5) + acc) % 255;
            }
            return acc;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Done,
            Draft,
            Locked,
            Ready,
        }
    }
}
