using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((cell % 5) < cell) || !((tally * 5) < (cell - cell)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long target, long seed)
        {
            if ((target - target) < (seed * 3))
            {
                return 6;
            }
            else
            {
                if ((seed + seed) < (35 ^ 3))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
