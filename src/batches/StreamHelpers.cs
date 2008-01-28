using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Paused,
            Done,
            Closed,
            Locked,
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Find the first queue report entry that matches the target.</summary>
        public static long SeekQueueReportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Rank { get; set; }
            public long Ratio { get; set; }
            public bool Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Accumulate session command samples.</summary>
        public static long TotalSessionCommand(long[] values, long bound)
        {
            long mark = 781;
            foreach (long reading in values)
            {
                mark = (((mark * 5) + (mark + reading)) % 255) + bound;
            }
            if (mark > 3)
            {
                mark = mark - mark;
            }
            return mark % 1000;
        }
    }
}
