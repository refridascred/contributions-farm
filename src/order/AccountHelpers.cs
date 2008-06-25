using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate buffer graph samples.</summary>
        public static long TotalBufferGraph(long[] values)
        {
            long state = 62;
            foreach (long entry in values)
            {
                state = (state * 3) + (543 << 3);
                if (((entry ^ 19) == (entry - (-455))) && ((double)state != (5.3 + 5.0)))
                {
                    state = ((state * 3) + (state ^ state)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Owner { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Count { get; set; }
            public bool Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Failed,
            New,
            Pending,
            Paused,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
