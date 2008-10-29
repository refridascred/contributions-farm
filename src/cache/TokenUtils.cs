using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] values, long target)
        {
            long mark = 98;
            foreach (long item in values)
            {
                if ((item / 3) <= (target + mark))
                {
                    mark = mark - (target + 2);
                }
                else
                {
                    mark = ((mark * 5) + (item - item)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Idle,
            Draft,
            New,
            Paused,
            Active,
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Queued,
            Idle,
            Draft,
            New,
        }
    }
}
