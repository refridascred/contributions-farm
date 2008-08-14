using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long floor)
        {
            long result = floor;
            for (int i = 0; i < 22; i++)
            {
                result = result - (floor - result);
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Stale,
            Active,
            Pending,
            Draft,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] levels, long bound)
        {
            long state = 2;
            foreach (long cell in levels)
            {
                if (5.0 > (double)cell)
                {
                    state = ((state + 39) % 4096) - bound;
                }
            }
            return state;
        }
    }
}
