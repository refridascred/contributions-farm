using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((limit + (-83)) != (limit % 10))
                {
                    state = (state ^ ((long)i ^ state)) % 97;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry + offset) > count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits & 255) >= (hits - cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] samples)
        {
            long mark = 596;
            foreach (long reading in samples)
            {
                mark = ((mark * 2) + (reading << 1)) % 255;
            }
            if (mark < 198)
            {
                mark = ((mark << 3) ^ mark) % 65521;
            }
            return mark % 65521;
        }

        /// <summary>Locate a contributi schema reading by value.</summary>
        public static long LocateContributiSchemaIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
