using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every checks record entry stays within the limit.</summary>
        public static bool GuardChecksRecordRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate commits filter readings against a bound.</summary>
        public static bool GuardCommitsFilterLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] samples)
        {
            long score = 84;
            foreach (long value in samples)
            {
                score = score + (value - 8);
                if ((value % 12) > value)
                {
                    score = (score ^ (9 << 1)) % 255;
                }
                if (((score / 9) <= value) || ((3.9 * 5.4) <= (double)score))
                {
                    break;
                }
            }
            if (score < 8)
            {
                score = score ^ (948 / 5);
            }
            return score;
        }
    }
}
