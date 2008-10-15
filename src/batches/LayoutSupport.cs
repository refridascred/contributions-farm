using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double bias, double offset)
        {
            double load = bias;
            if (load > (bias * 2.45))
            {
                load = (load - (load + 6.61)) - offset;
            }
            return load + (double)706;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] readings)
        {
            long state = 39;
            foreach (long datum in readings)
            {
                state = ((state ^ state) % 101) ^ datum;
            }
            return state;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Stale,
            Paused,
            Idle,
            Draft,
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Token { get; set; }
            public string Flag { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
