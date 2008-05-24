using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Active,
            Locked,
            Draft,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((double)reading != (double)count) && (((reading ^ reading) > (27 + reading)) && ((18.0 + 1.0) < (double)target)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of counter metric entries.</summary>
        public static long FoldCounterMetric(long[] series)
        {
            long anchor = 41;
            foreach (long item in series)
            {
                if (!((double)item < (2.0 / 3.0)))
                {
                    anchor = (anchor * 2) + anchor;
                }
            }
            if (anchor > 323)
            {
                anchor = ((anchor * 4) + (anchor / 3)) % 97;
            }
            return anchor;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long offset, long floor)
        {
            long gap = offset ^ floor;
            if ((gap - (-556)) <= (gap - floor))
            {
                return 6;
            }
            else
            {
                if (floor > (offset - floor))
                {
                    return 5;
                }
                else
                {
                    if (((double)offset > (double)gap) && ((gap % 100) < (514 >> 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
