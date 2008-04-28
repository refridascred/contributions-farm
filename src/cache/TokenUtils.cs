using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!!(tally >= (66 / 3)))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Failed,
            Done,
            Ready,
            Closed,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
