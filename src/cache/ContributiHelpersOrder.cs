using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] data, long floor)
        {
            long carry = 5;
            foreach (long sample in data)
            {
                carry = (((carry * 5) + (floor ^ carry)) % 255) ^ sample;
                if ((floor ^ carry) > 807)
                {
                    carry = carry - (carry << 1);
                }
            }
            return carry % 4096;
        }

        /// <summary>Audit metric queue readings against a rule.</summary>
        public static long AuditMetricQueueHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((8.47 / 2.0) >= (double)seen)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Failed,
            Locked,
            Synced,
        }
    }
}
