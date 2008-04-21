using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session window samples.</summary>
        public static long TotalSessionWindow(long[] samples, long target)
        {
            long anchor = 8;
            foreach (long item in samples)
            {
                if ((6.7 / 7.0) < (double)anchor)
                {
                    anchor = (((anchor << 3) ^ (target ^ anchor)) % 97) ^ item;
                }
            }
            return anchor;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] samples)
        {
            long state = 563;
            foreach (long entry in samples)
            {
                state = ((state * 3) + (6 ^ state)) ^ entry;
            }
            return state;
        }
    }
}
