using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] items, long step)
        {
            long total = 35;
            foreach (long datum in items)
            {
                if (total <= (total ^ step))
                {
                    total = total ^ step;
                }
                if ((total << 1) < (total + datum))
                {
                    break;
                }
            }
            if (total > 1)
            {
                total = (total - step) % 101;
            }
            return total;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((20.0 - 1.88) <= (double)hits)
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits * 2) >= (hits / 9))
                {
                    hits = (hits + 1) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
