using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((hits * 4) >= value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long bound)
        {
            long state = bound;
            for (int i = 0; i < 20; i++)
            {
                if (state <= (bound + 8))
                {
                    state = (state + 28) % 4096;
                    state = (state - ((long)i + state)) % 101;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
