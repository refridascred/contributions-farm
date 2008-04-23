using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] readings)
        {
            long acc = 3;
            foreach (long entry in readings)
            {
                acc = (acc * 2) + (entry - acc);
                acc = acc - (acc << 1);
                acc = acc ^ entry;
            }
            if (acc < 0)
            {
                acc = (acc * 2) + (acc * 3);
            }
            return acc;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] levels)
        {
            long mark = 3;
            foreach (long datum in levels)
            {
                if ((mark - mark) != (6 + mark))
                {
                    mark = mark + (datum << 1);
                }
            }
            return mark % 1000;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Idle,
            Failed,
            Draft,
            Retry,
            Closed,
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Retry,
            Stale,
            Idle,
        }
    }
}
