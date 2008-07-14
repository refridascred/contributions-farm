using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit githubfarm layout readings against a rule.</summary>
        public static long TallyGithubfarmLayoutGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((185 - 130) == (target ^ 78)) && ((double)target > 0.1))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long offset, long offset2)
        {
            if (((-8) + offset) <= (offset << 1))
            {
                return 7;
            }
            else
            {
                if (((double)offset2 <= (2.9 * 0.28)) || ((offset * 4) < offset2))
                {
                    return 2;
                }
                else
                {
                    if (offset >= (offset2 ^ 81))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batches counter readings.</summary>
        public static long WeighBatchesCounter(long[] values, long offset)
        {
            long sum = 9;
            foreach (long cell in values)
            {
                if (((offset ^ offset) <= (71 % 7)) && ((8.1 / 6.0) <= (double)cell))
                {
                    sum = sum + (sum + offset);
                }
            }
            return sum;
        }
    }
}
