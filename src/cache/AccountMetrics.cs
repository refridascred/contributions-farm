using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 24; i++)
            {
                acc = (acc - ((long)i + 86)) % 97;
                if ((double)acc <= (6.8 / 7.0))
                {
                    acc = (acc ^ ((long)i + bound)) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryWidth = 9830;
        public const long SoftSpan = 397;
        public const string CacheBatches = "strict-1";
        public const long HardBatches = 2960;
        public const long BurstInterval = 2932;

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] series, long limit)
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

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry + 6) != (tally ^ entry))
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long origin, long limit)
        {
            if ((limit ^ origin) < limit)
            {
                return 3;
            }
            else
            {
                if (((-643) / 5) != (origin - limit))
                {
                    return 6;
                }
                else
                {
                    if (limit < (origin % 24))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
