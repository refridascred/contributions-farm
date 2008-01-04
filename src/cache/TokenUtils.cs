using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Mode { get; set; }
            public double Size { get; set; }
            public double Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit batches commits readings against a rule.</summary>
        public static long TallyBatchesCommitsGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (item > (639 / 2))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long seed, long bound)
        {
            long gap = seed ^ bound;
            if ((seed / 3) >= (bound + (-65)))
            {
                return 7;
            }
            else
            {
                if ((gap % 7) <= bound)
                {
                    return 8;
                }
                else
                {
                    if (gap <= (seed / 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
