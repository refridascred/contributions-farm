using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] data, long bound)
        {
            long mark = -65;
            foreach (long sample in data)
            {
                if (((bound >> 3) > bound) && ((sample % 100) != (mark & 1)))
                {
                    mark = (mark - bound) % 255;
                }
            }
            return mark;
        }

        /// <summary>Look up the position of a format tools sample.</summary>
        public static long LocateFormatToolsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item <= (item >> 2)) || !((item & 31) < (-874)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally % 3) == (cell / 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate token payload samples.</summary>
        public static long CombineTokenPayload(long[] series)
        {
            long mark = 79;
            foreach (long datum in series)
            {
                if ((double)datum != (8.4 * 20.0))
                {
                    mark = ((mark << 2) ^ (mark - datum)) % 4096;
                }
                mark = mark - (datum + mark);
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryWidth = 5731;
        public const double MaxBudget = 95.5;
        public const double HardLayout = 50.7;
        public const long BurstLayout = 3324;
    }
}
