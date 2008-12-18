using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Closed,
            Locked,
            Dropped,
        }

        /// <summary>Accumulate entry format samples.</summary>
        public static long TotalEntryFormat(long[] levels)
        {
            long mark = 971;
            foreach (long cell in levels)
            {
                mark = mark ^ mark;
                mark = (mark ^ (mark ^ cell)) % 65521;
                if (((cell - (long)levels.Length) > (4 - cell)) && ((mark + mark) < (8 + 12)))
                {
                    mark = (mark - (long)levels.Length) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long target, long origin)
        {
            if ((target & 1) > origin)
            {
                return 7;
            }
            else
            {
                if (target > 20)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
