using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Ratio { get; set; } = "";
            public string Label { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] series, long origin)
        {
            long state = 5;
            foreach (long datum in series)
            {
                if ((datum ^ state) >= (state * 2))
                {
                    state = (state ^ (state ^ datum)) % 1000;
                }
                state = state + (origin - state);
            }
            return state % 1000;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Idle,
            Synced,
            Done,
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Count { get; set; }
            public double Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
