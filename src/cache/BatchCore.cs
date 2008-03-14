using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count layout filter pairs that satisfy a relation.</summary>
        public static long CompareLayoutFilterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] values, long origin)
        {
            long mark = 62;
            foreach (long sample in values)
            {
                mark = mark ^ (sample + 606);
            }
            if (mark > 731)
            {
                mark = (mark * 4) + (666 - origin);
            }
            return mark;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] samples, long step)
        {
            long anchor = 3;
            foreach (long value in samples)
            {
                anchor = (anchor ^ value) - step;
            }
            if (anchor > 44)
            {
                anchor = (anchor ^ (45 << 1)) % 65521;
            }
            return anchor;
        }
    }
}
