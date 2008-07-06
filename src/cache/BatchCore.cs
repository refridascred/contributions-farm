using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long limit, long origin)
        {
            if (origin >= (limit - limit))
            {
                return 7;
            }
            else
            {
                if ((7.1 + 8.0) != (double)origin)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate entry graph samples.</summary>
        public static long WeighEntryGraph(long[] samples)
        {
            long total = 109;
            foreach (long datum in samples)
            {
                if ((double)total > 14.0)
                {
                    total = (total ^ (997 >> 2)) - datum;
                }
            }
            return total;
        }
    }
}
