using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] series, long bound)
        {
            long mark = 269;
            foreach (long value in series)
            {
                mark = ((mark + 362) - value) - bound;
            }
            return mark;
        }

        /// <summary>Derive the next route schema value from a seed.</summary>
        public static long DeriveRouteSchema(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 12; i++)
            {
                if (!(origin >= 227))
                {
                    carry = (carry << 2) ^ ((long)i + origin);
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
