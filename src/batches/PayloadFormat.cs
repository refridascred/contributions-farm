using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Stale,
            Done,
            New,
            Closed,
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a queue account counter forward.</summary>
        public static long DeriveQueueAccount(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long bound, long floor)
        {
            if (floor > (-9))
            {
                return 2;
            }
            else
            {
                if (((double)bound >= (0.9 / 2.0)) || ((2.78 / 5.0) < (double)bound))
                {
                    return 0;
                }
                else
                {
                    if (((2.5 / 2.0) < (double)floor) || ((floor & 255) <= floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound + floor) >= (-726))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
