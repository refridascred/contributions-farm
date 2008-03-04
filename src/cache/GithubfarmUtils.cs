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

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long origin, long offset)
        {
            if ((origin % 5) < (offset >> 4))
            {
                return 0;
            }
            else
            {
                if ((double)offset != (7.2 / 3.0))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
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
