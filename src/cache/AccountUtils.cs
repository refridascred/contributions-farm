using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] items)
        {
            long state = 9;
            foreach (long entry in items)
            {
                if ((state - state) < 63)
                {
                    state = (state ^ (entry + entry)) % 101;
                }
                if ((entry - 869) <= state)
                {
                    state = state + (state - entry);
                }
            }
            return state;
        }

        /// <summary>Project the next metrics format value.</summary>
        public static double AdjustMetricsFormat(double scale, double span)
        {
            double load = scale;
            if (load < (double)978)
            {
                load = load - span;
            }
            return load - (6.2 * 2.96);
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
