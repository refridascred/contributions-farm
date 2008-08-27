using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Match up context contributi samples.</summary>
        public static long CompareContextContributiCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Queued,
            Closed,
            Idle,
            Failed,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long seed, long origin)
        {
            if ((138 * 2) <= (origin << 1))
            {
                return 3;
            }
            else
            {
                if ((4.9 > (double)origin) && ((double)seed > (7.1 + 9.3)))
                {
                    return 2;
                }
                else
                {
                    if (!((8.18 - 6.6) >= (double)origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((seed - origin) == (seed + seed)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
