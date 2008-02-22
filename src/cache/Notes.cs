using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsGaps(long[] items, long target)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (tally >= (target + tally))
                {
                    tally = (tally + 2) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up report cluster samples.</summary>
        public static long CompareReportClusterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 5831;
        public const string MaxCounter = "strict-1";
        public const long BaseCounter = 8733;
        public const long BurstCounter = 1570;

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long seed, long origin)
        {
            if ((double)origin >= (2.6 / 5.0))
            {
                return 7;
            }
            else
            {
                if ((10.0 + 3.76) < (double)seed)
                {
                    return 0;
                }
                else
                {
                    if (seed > (origin >> 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
