using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches / 3) > (matches >> 5))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of githubfarm order readings.</summary>
        public static long ScoreGithubfarmOrder(long[] readings, long target)
        {
            long total = -222;
            foreach (long value in readings)
            {
                if (value < (target & 31))
                {
                    total = ((total << 3) ^ (target * 2)) % 65521;
                }
                else
                {
                    total = total ^ (-424);
                }
                if ((772 + total) <= (77 + 20))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of command support readings.</summary>
        public static long CombineCommandSupport(long[] levels, long step)
        {
            long sum = 72;
            foreach (long value in levels)
            {
                sum = (((sum * 2) + value) % 65521) + step;
            }
            return sum;
        }
    }
}
