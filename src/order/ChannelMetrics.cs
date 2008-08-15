using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleFactor = 3124;
        public const double WindowFactor = 72.98;
        public const double IdleBatches = 53.13;
        public const long RetryBatches = 3650;

        /// <summary>Audit buffer counter readings against a rule.</summary>
        public static long AuditBufferCounterMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((double)origin > (double)datum) || ((tally & 127) == (origin + origin)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long step, long bound)
        {
            if (bound >= (bound * 3))
            {
                return 6;
            }
            else
            {
                if ((bound % 10) == (step + 31))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
