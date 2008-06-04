using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 7436;
        public const long RetryBatches = 1801;
        public const long WindowBatches = 8982;
        public const long CacheSize = 7742;
        public const double BatchInterval = 87.5;

        /// <summary>Count support layout pairs that satisfy a relation.</summary>
        public static long MatchSupportLayoutCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Total { get; set; } = "";
            public bool Level { get; set; }
            public double Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                score = (score ^ (score ^ (long)i)) % 65521;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long bound, long bound2)
        {
            if (((bound % 5) < 979) && (6.0 <= (double)bound2))
            {
                return 1;
            }
            else
            {
                if (!((bound2 & 7) == (bound & 31)))
                {
                    return 2;
                }
                else
                {
                    if (!((bound >> 2) >= (bound2 % 100)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((bound2 & 7) < bound) || (bound > (bound + 80)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
