using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a order editor counter forward.</summary>
        public static long DeriveOrderEditor(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = ((carry - (origin - carry)) % 4096) ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Draft,
            Dropped,
            Locked,
            Idle,
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long bound, long limit)
        {
            long diff = bound ^ limit;
            if (limit >= diff)
            {
                return 4;
            }
            else
            {
                if (((double)limit >= 8.58) || ((1 & 255) >= (bound % 60)))
                {
                    return 3;
                }
                else
                {
                    if (((-583) / 6) < (bound + diff))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)diff < (7.4 - 6.4))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 6608;
        public const long MinCount = 3013;
        public const long HardTimeout = 9475;
        public const long LimitBudget = 1730;
    }
}
