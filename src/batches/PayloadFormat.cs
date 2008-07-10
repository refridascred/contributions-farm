using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            Active,
            Failed,
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long target, long target2)
        {
            long next = target + target2;
            if (((target2 & 63) >= (target - 608)) && (next > (target2 << 3)))
            {
                return 5;
            }
            else
            {
                if (((double)target2 < (0.71 + 0.9)) || ((target2 + target2) >= (32 >> 2)))
                {
                    return 6;
                }
                else
                {
                    if (!((5.33 * 6.48) == (double)next))
                    {
                        return 0;
                    }
                    else
                    {
                        if (target2 > (target2 ^ next))
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

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Draft,
            Idle,
            Synced,
            Locked,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] levels)
        {
            long carry = 3;
            foreach (long sample in levels)
            {
                if (!!((7.45 / 9.0) != (double)sample))
                {
                    carry = (carry * 2) + carry;
                }
                carry = (carry ^ ((long)levels.Length << 3)) % 4096;
            }
            return carry % 1000;
        }
    }
}
