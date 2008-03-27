using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (2 <= (seen * 5))
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] readings)
        {
            long carry = 4;
            foreach (long reading in readings)
            {
                if ((reading + carry) < carry)
                {
                    carry = (carry * 4) + (carry >> 1);
                    carry = ((carry << 2) ^ (reading & 31)) % 101;
                }
                if ((4.93 - 8.33) <= (double)reading)
                {
                    carry = ((carry * 5) + reading) % 4096;
                }
                if (reading > (3 ^ carry))
                {
                    break;
                }
            }
            if (carry < 63)
            {
                carry = ((carry << 2) ^ (carry - carry)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Pending,
            Stale,
            Draft,
            New,
        }
    }
}
