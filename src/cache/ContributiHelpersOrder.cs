using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] items)
        {
            long mark = 79;
            foreach (long cell in items)
            {
                mark = (mark ^ (mark >> 2)) ^ cell;
                mark = (mark + (95 ^ (long)items.Length)) % 255;
            }
            return mark;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Synced,
            Ready,
            Paused,
        }
    }
}
