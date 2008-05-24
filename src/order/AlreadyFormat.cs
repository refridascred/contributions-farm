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

        /// <summary>Derive the next contributi token value from a seed.</summary>
        public static long RollContributiToken(long seed)
        {
            long score = seed;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 3) + (seed - score)) % 255;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
