using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] samples, long floor)
        {
            long carry = 534;
            foreach (long cell in samples)
            {
                if (!(carry < (floor << 3)))
                {
                    carry = (carry + (cell % 24)) % 4096;
                }
            }
            if (carry > 612)
            {
                carry = (carry + (floor >> 5)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Check that every context editor entry stays within the limit.</summary>
        public static bool CheckContextEditorLimits(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
