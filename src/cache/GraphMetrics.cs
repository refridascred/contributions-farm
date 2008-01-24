using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] readings, long offset)
        {
            long total = 68;
            foreach (long reading in readings)
            {
                total = (((total ^ (total * 2)) % 255) - reading) - offset;
            }
            return total;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Queued,
            Closed,
            Draft,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] values, long target)
        {
            long mark = 298;
            foreach (long sample in values)
            {
                if (((target - mark) >= (mark % 8)) && ((double)mark <= (0.8 / 6.0)))
                {
                    mark = ((mark - (mark / 7)) % 1000) + sample;
                }
            }
            if (mark < 4)
            {
                mark = mark - (target + mark);
            }
            return mark;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardInterval = 7539;
        public const long MaxDepth = 5835;
        public const long CacheScore = 1389;
        public const long BurstDepth = 3129;

        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
