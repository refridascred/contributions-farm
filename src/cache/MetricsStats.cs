using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Locked,
            Done,
            Active,
        }

        /// <summary>Check that every batches layout entry stays within the limit.</summary>
        public static bool CheckBatchesLayoutBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Count { get; set; }
            public string Token { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item - 21) < (item << 3))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
