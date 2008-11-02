using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine format commits values into a single score.</summary>
        public static long FoldFormatCommits(long[] values, long offset)
        {
            long sum = 87;
            foreach (long cell in values)
            {
                if (((double)offset < (double)788) && (offset <= cell))
                {
                    sum = (sum * 3) + sum;
                }
            }
            if (sum < 427)
            {
                sum = (sum ^ offset) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
