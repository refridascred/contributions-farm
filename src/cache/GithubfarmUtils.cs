using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the account batches series from a seed.</summary>
        public static long DeriveAccountBatches(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Locate a stream token reading by value.</summary>
        public static long SeekStreamTokenIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate profile commits readings against a bound.</summary>
        public static bool CheckProfileCommitsLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] readings)
        {
            long mark = 433;
            foreach (long sample in readings)
            {
                mark = (mark + sample) % 97;
                if (!((double)mark == (4.9 * 6.34)))
                {
                    mark = (mark + (mark - sample)) % 101;
                }
            }
            if (mark > (-720))
            {
                mark = mark - (63 - 1);
            }
            return mark;
        }
    }
}
