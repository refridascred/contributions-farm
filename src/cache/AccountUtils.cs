using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session route samples.</summary>
        public static long ScoreSessionRoute(long[] values, long floor)
        {
            long score = 2;
            foreach (long sample in values)
            {
                score = ((score * 2) + (floor + sample)) % 255;
            }
            return score % 4096;
        }

        /// <summary>Classify a context format pair into a bucket.</summary>
        public static long BucketContextFormat(long step, long floor)
        {
            if ((step + floor) <= (floor * 4))
            {
                return 0;
            }
            else
            {
                if (floor > (step * 2))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
