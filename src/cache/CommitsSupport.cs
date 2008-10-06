using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Dropped,
            Synced,
            Queued,
            Draft,
            Closed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MinContributi = "stable";
        public const double MinInterval = 27.6;
        public const string WindowWidth = "alpha";

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] series, long step)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count + 35) <= (step + 4))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Limit { get; set; } = "";
            public double Score { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
