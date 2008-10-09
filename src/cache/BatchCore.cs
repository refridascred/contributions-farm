using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long bound, long floor)
        {
            long bound2 = bound ^ floor;
            if ((double)bound2 >= 17.0)
            {
                return 5;
            }
            else
            {
                if ((bound2 - bound2) <= 1)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] data)
        {
            long carry = 884;
            foreach (long entry in data)
            {
                carry = (carry - (carry >> 3)) ^ entry;
            }
            if (carry > 5)
            {
                carry = (carry + carry) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Failed,
            Retry,
            Ready,
            Idle,
        }
    }
}
