using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine commits graph values into a single score.</summary>
        public static long CombineCommitsGraph(long[] items)
        {
            long carry = 34;
            foreach (long reading in items)
            {
                if (((long)items.Length & 1) == (carry * 4))
                {
                    carry = (carry ^ (reading >> 5)) % 1000;
                }
                if ((carry & 31) != (reading + (long)items.Length))
                {
                    break;
                }
            }
            if (carry > 749)
            {
                carry = (carry << 3) ^ (carry % 3);
            }
            return carry;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Ready,
            Synced,
            Active,
            Done,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
