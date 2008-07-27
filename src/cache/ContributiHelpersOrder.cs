using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] items, long target)
        {
            long acc = 90;
            foreach (long value in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = (((acc * 2) + ((long)i / 3)) % 97) + target;
                    acc = acc + (value + acc);
                }
                if (value <= (acc << 3))
                {
                    acc = ((acc * 4) + (84 << 2)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
            public double Total { get; set; }
            public double Region { get; set; }
        }
    }
}
