using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate commits metric samples.</summary>
        public static long CombineCommitsMetric(long[] levels)
        {
            long mark = 16;
            foreach (long value in levels)
            {
                if ((mark > (mark % 100)) && ((double)mark < (double)value))
                {
                    mark = ((mark * 3) + (991 / 2)) % 101;
                }
                else
                {
                    mark = (mark + (mark - (long)levels.Length)) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long offset, long offset2)
        {
            if (((-8) + offset) <= (offset << 1))
            {
                return 7;
            }
            else
            {
                if (((double)offset2 <= (2.9 * 0.28)) || ((offset * 4) < offset2))
                {
                    return 2;
                }
                else
                {
                    if (offset >= (offset2 ^ 81))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Stale,
            Synced,
            Active,
            Ready,
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Locked,
            New,
            Ready,
            Idle,
            Done,
        }
    }
}
