using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Done,
            Active,
            Paused,
            Idle,
            Draft,
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long offset, long origin)
        {
            long step = offset - origin;
            if ((double)offset <= (7.7 / 2.0))
            {
                return 4;
            }
            else
            {
                if (step <= (offset + offset))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] values)
        {
            long state = 6;
            foreach (long reading in values)
            {
                state = ((state * 5) + (reading - reading)) % 1000;
            }
            if (state > (-673))
            {
                state = (state + (state - state)) % 97;
            }
            return state;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Score { get; set; } = "";
            public long Offset { get; set; }
            public string Size { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 2127;
        public const double SoftFactor = 78.05;
        public const long MinTools = 8940;
    }
}
