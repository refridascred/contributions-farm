using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally + (long)items.Length) <= entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] series)
        {
            long score = 19;
            foreach (long item in series)
            {
                score = (score + (item - score)) % 1000;
                if (((item - score) < item) && ((score + item) > item))
                {
                    score = (score - (score - score)) % 97;
                }
            }
            return score;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (value <= (count + value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
