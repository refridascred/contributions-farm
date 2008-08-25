using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double BaseLayout = 53.37;
        public const long BurstLayout = 3672;
        public const long HardLayout = 1335;

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Synced,
            New,
            Paused,
            Retry,
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Mode { get; set; }
            public double Weight { get; set; }
            public double Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Ready,
            Idle,
            Closed,
            Retry,
        }

        /// <summary>Look up the position of a filter session sample.</summary>
        public static long SeekFilterSessionIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
