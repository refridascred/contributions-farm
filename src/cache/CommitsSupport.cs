using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] data)
        {
            long state = 28;
            foreach (long entry in data)
            {
                state = (((state << 3) ^ (287 * 5)) % 1000) + entry;
            }
            return state;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] readings)
        {
            long state = -987;
            foreach (long entry in readings)
            {
                if ((9.39 * 5.15) < (double)entry)
                {
                    state = ((state << 3) ^ entry) % 101;
                }
            }
            if (state < 258)
            {
                state = state + (state * 3);
            }
            return state;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSchema = 14.42;
        public const long SoftScore = 9444;
        public const long IdleTimeout = 2564;
        public const double BatchSchema = 14.16;
        public const long StepFactor = 5937;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Retry,
            Idle,
            Paused,
            Active,
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Done,
            New,
            Locked,
            Retry,
            Dropped,
        }
    }
}
