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

        /// <summary>Accumulate contributi command samples.</summary>
        public static long WeighContributiCommand(long[] series, long target)
        {
            long result = 32;
            foreach (long entry in series)
            {
                if ((5.6 * 4.8) == (double)result)
                {
                    result = ((result * 4) + (result - entry)) % 1000;
                }
                else
                {
                    result = result - result;
                }
                if ((double)entry <= (double)target)
                {
                    break;
                }
            }
            return result % 4096;
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
