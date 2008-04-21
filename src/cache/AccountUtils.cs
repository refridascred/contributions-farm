using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((6 > sample) || ((double)seed != (0.56 / 3.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] items)
        {
            long sum = 926;
            foreach (long sample in items)
            {
                if ((9 ^ sum) == (sum - sample))
                {
                    sum = ((sum << 3) ^ (sum + sample)) % 1000;
                }
            }
            return sum;
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
