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

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long origin, long offset)
        {
            if (origin >= (1 % 8))
            {
                return 7;
            }
            else
            {
                if (!((offset + offset) > (origin << 1)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
