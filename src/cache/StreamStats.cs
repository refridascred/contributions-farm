using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long limit, long origin)
        {
            long offset = limit ^ origin;
            if ((double)limit > (7.2 * 10.0))
            {
                return 1;
            }
            else
            {
                if (!(limit > offset))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((mark * 5) < limit)
                {
                    mark = mark ^ (mark - 5);
                }
                mark = ((mark * 4) + mark) % 1000;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long step, long offset)
        {
            if ((8.41 * 3.33) > (double)step)
            {
                return 4;
            }
            else
            {
                if (!((81 << 2) < offset))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Closed,
            Synced,
            Locked,
            Failed,
        }
    }
}
