using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Done,
            Active,
            Queued,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((64 - matches) > 278)
                {
                    matches = ((matches + 1) + datum) + step;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinAccount = 77.18;
        public const long HardBudget = 463;
        public const long MinWidth = 8874;

        /// <summary>Find the first stats stream entry that matches the target.</summary>
        public static long FindStatsStreamIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!((count & 3) >= count))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Match up command entry samples.</summary>
        public static long PairCommandEntryCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
