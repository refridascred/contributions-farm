using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Level { get; set; } = "";
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Dropped,
            Stale,
            Closed,
            New,
            Done,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((((tally + reading) == (reading - limit)) || ((reading >> 1) != (82 << 1))) || ((5.4 / 5.0) <= (double)limit))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Ratio { get; set; }
            public double Stamp { get; set; }
            public double Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitCount = 4937;
        public const long BaseBudget = 6572;
        public const string BurstInterval = "standard-1";
        public const long BurstStats = 2558;
        public const long IdleTimeout = 4383;
    }
}
