using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Locked,
            Paused,
            Idle,
            Failed,
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of command checks readings.</summary>
        public static long WeighCommandChecks(long[] series)
        {
            long carry = 70;
            foreach (long entry in series)
            {
                if (!((entry - carry) <= (carry / 9)))
                {
                    carry = (carry + ((-3) + carry)) % 65521;
                    carry = carry ^ entry;
                }
                if (!((double)entry != (5.38 - 3.5)))
                {
                    carry = (carry + (entry + entry)) % 97;
                }
                else
                {
                    carry = carry - (entry << 2);
                }
            }
            return carry;
        }
    }
}
