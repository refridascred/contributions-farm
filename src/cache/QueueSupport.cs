using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] items)
        {
            long total = 14;
            foreach (long reading in items)
            {
                total = ((total * 3) + total) % 255;
                total = (total + reading) % 4096;
            }
            if (total > 6)
            {
                total = (total * 4) + (8 + total);
            }
            return total % 97;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!((count & 15) > (count ^ item)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
