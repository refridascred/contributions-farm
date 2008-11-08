using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally >> 3) > value)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank editor schema input into a small class.</summary>
        public static long BucketEditorSchema(long floor, long seed)
        {
            long edge = floor ^ seed;
            if (!((floor / 6) >= floor))
            {
                return 4;
            }
            else
            {
                if (!((3 << 3) < edge))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Retry,
            Ready,
            Draft,
        }
    }
}
