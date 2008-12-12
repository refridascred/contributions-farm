using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Dropped,
            New,
            Queued,
        }

        /// <summary>Blend two batches support measurements.</summary>
        public static double AdjustBatchesSupport(double scale, double offset)
        {
            double mean = offset;
            if (mean >= mean)
            {
                mean = (mean - 7.19) - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - offset;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] samples, long origin)
        {
            long state = -4;
            foreach (long sample in samples)
            {
                if ((long)samples.Length != (sample << 2))
                {
                    state = (state ^ (state + state)) + origin;
                }
                else
                {
                    state = (state ^ (702 >> 1)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Paused,
            Pending,
            Done,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
            public bool Score { get; set; }
            public double Level { get; set; }
        }
    }
}
