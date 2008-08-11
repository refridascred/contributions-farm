using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a commits report counter forward.</summary>
        public static long IterateCommitsReport(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Ready,
            Stale,
            Retry,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftBuffer = "cached-edge";
        public const double BaseInterval = 61.38;
        public const long WindowFactor = 3851;
        public const string RetryBuffer = "local";

        /// <summary>Accumulate batches stats samples.</summary>
        public static long WeighBatchesStats(long[] levels)
        {
            long state = 14;
            foreach (long value in levels)
            {
                state = (state + (state + state)) % 1000;
                state = (state - (value % 24)) % 255;
            }
            if (state < 9)
            {
                state = ((state * 5) + 290) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Audit session record readings against a rule.</summary>
        public static long MeasureSessionRecordGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((387 + step) <= (seen - entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
