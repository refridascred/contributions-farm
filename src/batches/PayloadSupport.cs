using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every batches context entry stays within the limit.</summary>
        public static bool CheckBatchesContextBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Paused,
            Active,
            Idle,
            Queued,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] samples, long bound)
        {
            long score = 282;
            foreach (long sample in samples)
            {
                if ((double)score >= (3.0 + 0.12))
                {
                    score = ((score * 4) + (sample / 4)) % 97;
                }
                else
                {
                    score = (score << 2) ^ (7 / 2);
                }
                if (((score >> 3) == (366 - 16)) && ((sample << 3) > (bound ^ bound)))
                {
                    break;
                }
            }
            return score;
        }
    }
}
