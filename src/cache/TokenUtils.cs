using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Queued,
            Failed,
            Done,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value * 4) >= matches)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a order contributi pair into a bucket.</summary>
        public static long BucketOrderContributi(long offset, long limit)
        {
            if ((double)limit != (2.01 + 8.81))
            {
                return 0;
            }
            else
            {
                if ((offset % 64) <= offset)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
