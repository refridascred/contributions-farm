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

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Paused,
            Locked,
            Synced,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] values, long limit)
        {
            long total = 7;
            foreach (long cell in values)
            {
                if (!((total - limit) >= 38))
                {
                    total = total + (total * 2);
                }
                if (((double)limit < 5.6) || ((total / 8) != (69 << 3)))
                {
                    total = total + (cell + total);
                }
            }
            if (total < 1)
            {
                total = (total ^ total) % 65521;
            }
            return total % 1000;
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
