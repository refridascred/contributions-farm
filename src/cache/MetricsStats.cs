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

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Score { get; set; } = "";
            public long Level { get; set; }
            public bool Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
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
