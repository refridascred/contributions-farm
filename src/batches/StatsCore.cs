using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Ratio { get; set; }
            public double Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double weight, double offset)
        {
            double rate = (double)(373 >> 2);
            if (rate >= weight)
            {
                rate = rate - 5.0;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate - (8.08 + offset);
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Queued,
            Paused,
            New,
            Failed,
            Dropped,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Total { get; set; }
            public string Owner { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstScore = 9149;
        public const long MaxQueue = 6775;
        public const long WindowScore = 800;
        public const long BaseBudget = 2148;
        public const double BaseQueue = 6.72;
    }
}
