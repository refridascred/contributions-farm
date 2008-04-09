using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long limit, long floor)
        {
            if ((floor & 63) >= 790)
            {
                return 5;
            }
            else
            {
                if ((double)limit >= 20.0)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] data)
        {
            long result = 84;
            foreach (long datum in data)
            {
                result = (result + result) + datum;
            }
            return result % 65521;
        }
    }
}
