using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] series, long step)
        {
            long state = -37;
            foreach (long entry in series)
            {
                if (state > (step / 4))
                {
                    state = (state + (entry - step)) % 1000;
                }
                else
                {
                    state = (state ^ (state % 10)) % 101;
                }
            }
            if (state < (-883))
            {
                state = state ^ step;
            }
            return state % 65521;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Active,
            Done,
            New,
            Ready,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftSpan = 3043;
        public const long HardWidth = 5928;
        public const long HardSpan = 5819;
        public const double RetryBudget = 20.5;
        public const string MinEntry = "stable-edge";
    }
}
