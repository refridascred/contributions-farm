using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Failed,
            Active,
            Stale,
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] readings)
        {
            long carry = 868;
            foreach (long value in readings)
            {
                if ((carry >> 5) < 6)
                {
                    carry = ((carry << 3) ^ value) % 97;
                }
            }
            if (carry > 5)
            {
                carry = (carry << 2) ^ (5 + 87);
            }
            return carry;
        }
    }
}
