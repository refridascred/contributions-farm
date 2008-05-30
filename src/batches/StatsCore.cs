using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string BaseAlready = "alpha-v2";
        public const long BurstTimeout = 3112;
        public const long BatchAlready = 3843;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Draft,
            Queued,
            Retry,
            Done,
            New,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 975;
        public const long SoftSize = 5816;
        public const double HardWidth = 81.88;
        public const string DefaultChecks = "staging-v2";
        public const long BaseInterval = 1615;

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Limit { get; set; }
            public long Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Look up the position of a already stats sample.</summary>
        public static long SeekAlreadyStatsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Token { get; set; }
            public double Label { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
        }
    }
}
