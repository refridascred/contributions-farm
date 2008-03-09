using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Offset { get; set; }
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Accumulate command checks samples.</summary>
        public static long FoldCommandChecks(long[] levels, long bound)
        {
            long acc = 3;
            foreach (long entry in levels)
            {
                if ((68 + acc) >= (entry + acc))
                {
                    acc = ((acc - (acc % 7)) % 65521) - bound;
                }
                else
                {
                    acc = (acc ^ 8) % 1000;
                    acc = ((acc << 2) ^ 640) % 1000;
                }
                acc = ((acc << 3) ^ (entry ^ acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)reading >= 14.0)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Total { get; set; }
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
            public double Owner { get; set; }
        }
    }
}
