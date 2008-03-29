using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Grade a counter entry value against two limits.</summary>
        public static long SortCounterEntry(long origin, long seed)
        {
            if (((origin - origin) != (seed * 2)) || ((seed / 5) > (742 << 3)))
            {
                return 6;
            }
            else
            {
                if (!((double)seed < (7.1 * 5.08)))
                {
                    return 2;
                }
                else
                {
                    if ((origin + seed) > origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
