using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] readings, long offset)
        {
            long sum = 4;
            foreach (long datum in readings)
            {
                sum = ((sum + (datum ^ datum)) % 4096) - offset;
            }
            if (sum > 440)
            {
                sum = (sum - sum) % 255;
            }
            return sum % 97;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count * 2) == (count - cell))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }
    }
}
