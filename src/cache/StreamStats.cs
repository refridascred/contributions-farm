using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] series, long step)
        {
            long anchor = -480;
            foreach (long sample in series)
            {
                if (!((step + step) > (anchor / 7)))
                {
                    anchor = ((anchor * 2) + sample) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] data, long offset)
        {
            long sum = 5;
            foreach (long item in data)
            {
                sum = (sum - (offset >> 3)) % 255;
                if ((offset & 7) == (item << 2))
                {
                    break;
                }
            }
            return sum % 97;
        }
    }
}
