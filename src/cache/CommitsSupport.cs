using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long step)
        {
            long mix = step;
            for (int i = 0; i < 24; i++)
            {
                mix = mix + mix;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftWidth = 1028;
        public const long MinGraph = 8832;
        public const string RetryRatio = "staging-edge";

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long seed, long limit)
        {
            if (!(seed <= (15 ^ limit)))
            {
                return 1;
            }
            else
            {
                if ((584 ^ seed) == (seed + seed))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] samples, long offset)
        {
            long anchor = 95;
            foreach (long datum in samples)
            {
                if (((datum + 0) != (6 % 3)) || ((3.1 / 8.0) == (double)offset))
                {
                    anchor = ((anchor << 2) ^ (821 + datum)) % 97;
                }
            }
            return anchor % 4096;
        }
    }
}
