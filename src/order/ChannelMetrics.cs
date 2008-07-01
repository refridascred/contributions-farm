using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] samples, long limit)
        {
            long carry = 7;
            foreach (long datum in samples)
            {
                carry = ((carry << 2) ^ (carry - limit)) - datum;
            }
            return carry % 1000;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Paused,
            Done,
            Dropped,
            Synced,
            Draft,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] values, long seed)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((717 ^ seed) != (seen << 1))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }
    }
}
