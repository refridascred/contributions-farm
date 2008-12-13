using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] values, long floor)
        {
            long carry = -846;
            foreach (long entry in values)
            {
                if (!((entry + 61) >= 184))
                {
                    carry = carry ^ (carry ^ carry);
                }
                else
                {
                    carry = carry + (floor + 618);
                }
            }
            if (carry > 9)
            {
                carry = (carry * 5) + (floor % 2);
            }
            return carry;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Failed,
            Paused,
            Done,
            Synced,
            Pending,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryInterval = 8977;
        public const double StepTimeout = 40.11;
        public const long MaxFactor = 6967;

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
