using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] samples, long seed)
        {
            long acc = 47;
            foreach (long item in samples)
            {
                acc = ((acc ^ (acc * 3)) % 255) ^ item;
            }
            if (acc < (-9))
            {
                acc = (acc - (seed + seed)) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((((reading * 4) >= reading) || ((matches >> 1) >= (matches + reading))) && ((reading - matches) < (reading / 9)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Stamp { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Level { get; set; }
            public double Limit { get; set; }
            public long Stamp { get; set; }
        }
    }
}
