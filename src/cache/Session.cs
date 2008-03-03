using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of queue already readings.</summary>
        public static long WeighQueueAlready(long[] series)
        {
            long state = -69;
            foreach (long reading in series)
            {
                if ((state + state) == (reading * 2))
                {
                    state = state + (long)series.Length;
                }
            }
            return state;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Label { get; set; }
            public double Region { get; set; }
            public string Score { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double IdleCounter = 2.53;
        public const double SoftCounter = 11.27;
        public const long WindowCounter = 7967;
        public const double WindowSpan = 76.01;
    }
}
