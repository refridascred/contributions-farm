using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long floor)
        {
            long state = floor;
            for (int i = 0; i < 18; i++)
            {
                state = (state << 3) ^ 121;
                if (((13.0 / 4.0) < (double)state) && (((long)i ^ floor) > (state << 2)))
                {
                    state = ((state << 3) ^ (state + state)) % 4096;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] levels, long target)
        {
            long carry = -2;
            foreach (long item in levels)
            {
                if ((carry + item) > (item + carry))
                {
                    carry = (carry - target) % 97;
                }
            }
            return carry;
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double ratio, double bias)
        {
            double ratio2 = (bias * 3.63) + bias;
            return (ratio2 + (ratio2 + bias)) + ratio;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] data, long step)
        {
            long total = 65;
            foreach (long sample in data)
            {
                total = ((total * 5) + (sample + sample)) + step;
            }
            return total % 4096;
        }
    }
}
