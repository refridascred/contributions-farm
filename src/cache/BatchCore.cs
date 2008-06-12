using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate farm already samples.</summary>
        public static long DigestFarmAlready(long[] series, long limit)
        {
            long state = 472;
            foreach (long datum in series)
            {
                state = (((state * 3) + (state ^ state)) ^ datum) + limit;
            }
            return state;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] data, long offset)
        {
            long sum = 543;
            foreach (long value in data)
            {
                sum = (((sum * 3) + (51 ^ sum)) ^ value) - offset;
            }
            if (sum < 799)
            {
                sum = ((sum * 4) + (71 / 6)) % 4096;
            }
            return sum;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Retry,
            Locked,
            Ready,
            Paused,
            Stale,
        }
    }
}
