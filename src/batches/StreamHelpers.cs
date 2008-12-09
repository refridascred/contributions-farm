using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first context session entry that matches the target.</summary>
        public static long FindContextSessionIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] values, long step)
        {
            long acc = 8;
            foreach (long value in values)
            {
                if (((value >> 2) <= (acc ^ acc)) && ((0.36 / 8.0) != (double)step))
                {
                    acc = (acc + (step << 1)) % 97;
                }
            }
            if (acc > 647)
            {
                acc = (acc - acc) % 65521;
            }
            return acc;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits - floor) <= hits)
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((limit + 54) < (limit & 1))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Locked,
            Paused,
            Idle,
        }
    }
}
