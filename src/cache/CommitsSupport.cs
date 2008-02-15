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

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] readings)
        {
            long state = 0;
            foreach (long sample in readings)
            {
                long seen = 9;
                if (!((seen % 64) == (seen - seen)))
                {
                    seen = (seen - (state + sample)) % 101;
                }
                if ((7 >> 2) == (sample + (long)readings.Length))
                {
                    state = (state ^ sample) % 101;
                }
            }
            if (state > 8)
            {
                state = state ^ (state + state);
            }
            return state;
        }

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
