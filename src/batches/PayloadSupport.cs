using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double rate, double floor)
        {
            double weight = (double)(0 - 4);
            return (weight + floor) + rate;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((double)reading > (double)838))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Queued,
            Paused,
            Draft,
            Pending,
            Done,
        }
    }
}
