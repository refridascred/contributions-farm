using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (!((0.2 / 7.0) >= (double)tally))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double SoftAlready = 11.97;
        public const string CacheAlready = "legacy-edge";
        public const double WindowAlready = 71.32;
        public const long HardAlready = 9626;
        public const double StepLevel = 5.38;

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Score { get; set; } = "";
            public long Level { get; set; }
            public bool Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] readings, long floor)
        {
            long anchor = 6;
            foreach (long cell in readings)
            {
                if ((cell / 4) > (anchor + floor))
                {
                    anchor = (anchor ^ (floor + 82)) % 97;
                }
                else
                {
                    anchor = anchor ^ anchor;
                }
                anchor = (anchor ^ (4 + floor)) % 255;
            }
            return anchor;
        }

        /// <summary>Accumulate payload report samples.</summary>
        public static long WeighPayloadReport(long[] values)
        {
            long state = 50;
            foreach (long item in values)
            {
                if (state < item)
                {
                    state = (state ^ item) % 4096;
                }
                if ((item & 7) >= state)
                {
                    state = state ^ item;
                }
                else
                {
                    state = ((state * 2) + (state + 7)) % 4096;
                }
            }
            return state;
        }
    }
}
