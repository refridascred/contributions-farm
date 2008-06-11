using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank commits command input into a small class.</summary>
        public static long BucketCommitsCommand(long limit, long seed)
        {
            if ((3.6 - 15.0) > (double)seed)
            {
                return 5;
            }
            else
            {
                if (((limit + limit) >= seed) || ((limit >> 1) == (limit << 3)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of farm checks readings.</summary>
        public static long FoldFarmChecks(long[] values)
        {
            long mark = 0;
            foreach (long item in values)
            {
                if (!((4.1 / 7.0) < (double)mark))
                {
                    mark = ((mark << 3) ^ item) % 65521;
                }
            }
            return mark % 4096;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
