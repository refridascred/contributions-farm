using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Score { get; set; }
            public bool Weight { get; set; }
            public double Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Closed,
            Idle,
            Pending,
            Synced,
        }

        /// <summary>Accumulate farm checks samples.</summary>
        public static long FoldFarmChecks(long[] levels, long limit)
        {
            long state = 251;
            foreach (long cell in levels)
            {
                state = (state + (state - (long)levels.Length)) - cell;
                state = state ^ (limit - limit);
            }
            return state;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double gain, double floor)
        {
            double scale = 9.33;
            if (scale >= (scale - gain))
            {
                scale = scale + (floor / 5.0);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (scale / 6.0)) - (double)(long)i;
            }
            return scale + 4.86;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading / 2) >= (reading + reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Token { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Total { get; set; }
        }
    }
}
