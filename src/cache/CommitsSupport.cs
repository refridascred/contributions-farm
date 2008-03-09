using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 9349;
        public const long MinSpan = 6757;
        public const long DefaultQueue = 6653;

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of tools counter readings.</summary>
        public static long PairToolsCounterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit queue record readings against a rule.</summary>
        public static long MeasureQueueRecordMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)item >= (double)9)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (value > 931)
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a batch stream sample.</summary>
        public static long LookupBatchStreamIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
