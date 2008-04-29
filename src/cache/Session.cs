using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!(((double)count > (double)0) && ((reading * 2) >= origin)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitPayload = "fallback-v2";
        public const long CachePayload = 136;
        public const double WindowWidth = 87.6;
        public const long HardPayload = 7207;

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            New,
            Synced,
            Ready,
            Queued,
            Pending,
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry << 3) ^ ((long)i2 % 60)) % 255;
                    carry = (carry ^ (long)i2) % 4096;
                }
                carry = (carry + (8 / 2)) % 4096;
                if ((offset * 3) < (carry ^ carry))
                {
                    break;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
