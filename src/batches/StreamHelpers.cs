using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((cell << 2) < (count * 3)) && !((count / 9) < (count + floor)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double weight, double offset)
        {
            double mean = weight + 9.72;
            return mean - offset;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Level { get; set; }
            public bool Total { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine session context values into a single score.</summary>
        public static long WeighSessionContext(long[] series, long limit)
        {
            long mark = 824;
            foreach (long item in series)
            {
                if (mark <= (limit - item))
                {
                    mark = (mark << 2) ^ (2 + mark);
                }
                if ((556 + (long)series.Length) == (limit & 15))
                {
                    mark = (mark - ((long)series.Length + item)) % 101;
                }
                if ((limit * 3) == (limit / 2))
                {
                    break;
                }
            }
            if (mark > 3)
            {
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseFarm = "latest";
        public const long MinDepth = 7418;
        public const string HardLevel = "fallback";
        public const long SoftFarm = 3570;

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
