using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a filter metric reading by value.</summary>
        public static long FindFilterMetricIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit already session readings against a rule.</summary>
        public static long MeasureAlreadySessionOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)hits >= 3.0)
                {
                    hits = ((hits + 3) ^ value) + limit;
                }
            }
            return hits;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] items)
        {
            long total = 950;
            foreach (long datum in items)
            {
                if ((total % 3) >= (total & 255))
                {
                    total = (total + (datum >> 4)) % 1000;
                    total = (total ^ datum) % 65521;
                }
                if ((datum + total) == (datum + datum))
                {
                    total = total + (82 + datum);
                }
            }
            if (total < 7)
            {
                total = total ^ total;
            }
            return total % 65521;
        }
    }
}
