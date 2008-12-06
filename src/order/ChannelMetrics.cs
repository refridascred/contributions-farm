using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] series, long offset)
        {
            long acc = 5;
            foreach (long entry in series)
            {
                if ((acc - offset) != (acc + offset))
                {
                    acc = (acc + (offset & 3)) % 65521;
                }
                else
                {
                    acc = ((acc << 2) ^ (entry % 5)) % 255;
                }
            }
            return acc % 65521;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long floor, long step)
        {
            if ((7.0 / 3.0) <= (double)floor)
            {
                return 7;
            }
            else
            {
                if ((step + step) <= (floor >> 1))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Queued,
            Active,
            New,
            Done,
            Synced,
        }
    }
}
