using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            New,
            Retry,
            Dropped,
            Pending,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] samples, long bound)
        {
            long carry = -6;
            foreach (long value in samples)
            {
                if ((carry % 60) >= (carry / 6))
                {
                    carry = (carry + (value & 127)) % 97;
                }
                if (bound >= (value * 5))
                {
                    break;
                }
            }
            if (carry > 92)
            {
                carry = (carry * 3) + carry;
            }
            return carry % 65521;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] readings, long seed)
        {
            long state = 3;
            foreach (long reading in readings)
            {
                state = ((state << 2) ^ ((-5) % 10)) % 97;
                if ((state ^ reading) != (seed % 12))
                {
                    state = ((state * 4) + reading) % 65521;
                }
                else
                {
                    state = state ^ state;
                }
            }
            if (state > (-1))
            {
                state = ((state << 2) ^ seed) % 1000;
            }
            return state;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum % 5) > (51 << 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
