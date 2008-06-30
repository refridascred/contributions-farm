using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Active,
            Ready,
            Synced,
            Idle,
            Pending,
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long floor, long floor2)
        {
            if ((52 - floor) > (floor - 5))
            {
                return 5;
            }
            else
            {
                if ((1.0 - 18.0) > (double)floor)
                {
                    return 8;
                }
                else
                {
                    if (!((floor2 / 5) < (floor2 & 1)))
                    {
                        return 0;
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
