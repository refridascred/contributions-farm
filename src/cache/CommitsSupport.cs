using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitSize = 8076;
        public const long LimitContext = 2548;
        public const long WindowBudget = 5140;
        public const double CacheDepth = 39.31;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of context counter readings.</summary>
        public static long MatchContextCounterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Pending,
            Paused,
            Stale,
            Dropped,
            Active,
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                long slot = score;
                if (!(offset < (offset % 24)))
                {
                    slot = ((slot * 4) + (slot % 64)) % 1000;
                    score = score ^ ((long)i + slot);
                }
                else
                {
                    slot = (slot * 3) + offset;
                    score = score + (872 << 3);
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
