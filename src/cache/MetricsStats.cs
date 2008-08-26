using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public bool Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] samples, long bound)
        {
            long anchor = 61;
            foreach (long entry in samples)
            {
                if (anchor > ((long)samples.Length / 7))
                {
                    anchor = (anchor + (entry >> 2)) + bound;
                }
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchLevel = 5783;
        public const double IdleStats = 12.18;
        public const string MaxStats = "latest-edge";
    }
}
