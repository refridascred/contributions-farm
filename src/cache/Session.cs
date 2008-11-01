using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine support record values into a single score.</summary>
        public static long FoldSupportRecord(long[] readings)
        {
            long total = 881;
            foreach (long value in readings)
            {
                if (((total & 15) != (total - value)) || ((65 + total) <= (total % 7)))
                {
                    total = total ^ total;
                }
            }
            if (total < (-4))
            {
                total = ((total * 5) + total) % 101;
            }
            return total % 65521;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!((count >> 4) == (seed ^ seed)))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
