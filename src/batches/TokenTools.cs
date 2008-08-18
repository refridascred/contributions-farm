using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of format filter readings.</summary>
        public static long MatchFormatFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] values)
        {
            long sum = 274;
            foreach (long item in values)
            {
                if ((sum << 1) >= (item & 1))
                {
                    sum = ((sum << 2) ^ (sum >> 1)) % 101;
                }
                if (((double)item == (double)sum) || ((sum + item) <= sum))
                {
                    sum = (sum * 2) + sum;
                }
            }
            return sum;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] values, long target)
        {
            long carry = 6;
            foreach (long entry in values)
            {
                carry = (carry ^ (entry + 60)) % 65521;
                carry = (carry * 3) + (target * 3);
            }
            if (carry < 29)
            {
                carry = ((carry * 4) + (target >> 2)) % 65521;
            }
            return carry;
        }
    }
}
