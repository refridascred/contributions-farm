using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 5531;
        public const string IdleSupport = "stable-v2";
        public const long BaseSupport = 6223;
        public const double SoftSupport = 29.43;
        public const long BatchBudget = 1002;

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long offset, long origin)
        {
            long offset2 = offset + origin;
            if ((offset2 - offset) > offset2)
            {
                return 0;
            }
            else
            {
                if (57 <= (offset2 + offset))
                {
                    return 4;
                }
                else
                {
                    if ((offset2 * 4) < (offset - offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Digest a series of command session entries.</summary>
        public static long CombineCommandSession(long[] values, long step)
        {
            long mark = -170;
            foreach (long cell in values)
            {
                if ((double)step <= 6.53)
                {
                    mark = (mark * 5) + (mark + cell);
                }
                else
                {
                    mark = ((mark * 5) + step) % 97;
                }
            }
            return mark;
        }
    }
}
