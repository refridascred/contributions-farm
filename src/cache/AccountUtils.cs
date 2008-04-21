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

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)floor > 20.0)
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
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
