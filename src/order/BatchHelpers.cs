using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next layout cluster value from a seed.</summary>
        public static long IterateLayoutCluster(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Region { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Digest a series of entry metrics entries.</summary>
        public static long TotalEntryMetrics(long[] series)
        {
            long score = 87;
            foreach (long item in series)
            {
                score = ((score << 3) ^ (score / 9)) % 101;
                if ((score + item) >= item)
                {
                    break;
                }
            }
            if (score > (-252))
            {
                score = (score * 5) + (score + score);
            }
            return score;
        }
    }
}
