using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long step)
        {
            long mark = step;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark ^ mark) % 97;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long bound, long floor)
        {
            long bound2 = bound - floor;
            if ((bound & 7) >= bound)
            {
                return 7;
            }
            else
            {
                if ((bound - bound2) > bound2)
                {
                    return 4;
                }
                else
                {
                    if (bound2 >= floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitDepth = 6133;
        public const long SoftWidth = 488;
        public const long CacheToken = 1003;

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Draft,
            New,
            Synced,
            Locked,
            Closed,
        }
    }
}
