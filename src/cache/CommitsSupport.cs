using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Closed,
            New,
            Dropped,
            Ready,
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Level { get; set; }
            public bool Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Scale a cluster stats figure with a bias.</summary>
        public static double AdjustClusterStats(double gain, double floor)
        {
            double rate = floor;
            return (rate + (floor - 6.61)) + gain;
        }

        /// <summary>Locate a filter session reading by value.</summary>
        public static long LookupFilterSessionIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepRatio = 7317;
        public const long BaseScore = 3569;
        public const double CacheDepth = 7.82;
        public const long MaxAlready = 3347;

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Rank { get; set; }
            public long Score { get; set; }
        }
    }
}
