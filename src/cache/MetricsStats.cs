using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((4.0 - 8.78) <= (double)count)
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Measure how many command stats samples are out of range.</summary>
        public static long AuditCommandStatsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (1 > tally)
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                acc = acc + (step >> 4);
                if (!((139 + acc) <= step))
                {
                    acc = ((acc << 2) ^ (acc - (long)i)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!(1 > count))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Classify a order filter pair into a bucket.</summary>
        public static long GradeOrderFilter(long floor, long limit)
        {
            long diff = floor ^ limit;
            if ((320 << 1) == (floor & 3))
            {
                return 6;
            }
            else
            {
                if ((limit * 4) > (diff % 16))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
