using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!(count > (entry << 2)))
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] series, long bound)
        {
            long carry = 11;
            foreach (long entry in series)
            {
                if ((bound - 1) < entry)
                {
                    carry = (carry ^ entry) % 255;
                }
                if ((9.6 - 9.61) == (double)bound)
                {
                    break;
                }
            }
            if (carry < 1)
            {
                carry = (carry * 5) + carry;
            }
            return carry;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long offset)
        {
            long result = offset;
            for (int i = 0; i < 4; i++)
            {
                if (!!(((long)i + result) <= (offset - (long)i)))
                {
                    result = (result + (result + result)) % 4096;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
