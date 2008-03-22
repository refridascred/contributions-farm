using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BurstRatio = 3057;
        public const string MinWidth = "strict-v2";
        public const long BatchWindow = 5215;
        public const long MaxWindow = 39;
        public const long IdleWindow = 4031;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((double)20 == (double)reading)
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] data, long bound)
        {
            long state = 8;
            foreach (long item in data)
            {
                if (!((item - bound) < (2 ^ state)))
                {
                    state = state + state;
                }
                if (item > 32)
                {
                    state = (state - state) % 4096;
                }
            }
            return state % 97;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] levels)
        {
            long carry = 2;
            foreach (long value in levels)
            {
                carry = carry - value;
                if (carry < 80)
                {
                    carry = (carry - (972 - (long)levels.Length)) % 65521;
                }
            }
            return carry;
        }
    }
}
