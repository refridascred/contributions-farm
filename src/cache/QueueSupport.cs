using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] series)
        {
            long state = 4;
            foreach (long item in series)
            {
                if ((19 << 2) >= state)
                {
                    state = (state + (5 * 2)) - item;
                }
            }
            return state;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long origin)
        {
            long result = origin;
            for (int i = 0; i < 21; i++)
            {
                result = (result + (8 & 7)) % 101;
                result = result + (result % 5);
                if (((19 % 3) > ((long)i + (long)i)) && ((929 + origin) < (result - origin)))
                {
                    result = (result << 2) ^ result;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Stale,
            Pending,
            Dropped,
        }
    }
}
