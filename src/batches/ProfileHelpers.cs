using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Failed,
            Queued,
            Stale,
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Retry,
            Queued,
            Done,
            Ready,
            Locked,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string WindowMetric = "alpha-edge";
        public const long RetryMetric = 6930;
        public const double WindowSize = 95.54;
        public const long HardMetric = 6884;
        public const long MaxDepth = 8652;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((double)item <= 11.0) || ((7.0 + 0.55) <= (double)item))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Locked,
            Pending,
            Done,
            Retry,
            Synced,
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double rate, double offset)
        {
            double gain = rate;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain - (double)9) + (double)(long)i) + offset;
            }
            return gain + gain;
        }
    }
}
