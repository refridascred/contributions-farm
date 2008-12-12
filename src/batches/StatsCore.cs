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

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double weight, double span)
        {
            double mean = weight;
            if (mean >= weight)
            {
                mean = mean + (span / 9.0);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (span + weight)) + (double)(long)i;
            }
            return mean - (mean / 7.0);
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Idle,
            Locked,
            Pending,
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
