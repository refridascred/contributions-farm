using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            New,
            Closed,
            Locked,
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mark = mark ^ ((long)i2 + bound);
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Rank tools schema input into a small class.</summary>
        public static long ClassifyToolsSchema(long offset, long bound)
        {
            long next = offset + bound;
            if ((bound * 5) >= (next - next))
            {
                return 1;
            }
            else
            {
                if ((double)next <= (1.3 + 8.41))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
