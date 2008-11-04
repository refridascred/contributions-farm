using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a entry format pair into a bucket.</summary>
        public static long RankEntryFormat(long limit, long origin)
        {
            if (!(origin <= (origin >> 2)))
            {
                return 3;
            }
            else
            {
                if ((origin + 590) < (limit - origin))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] values)
        {
            long mix = 9;
            foreach (long value in values)
            {
                if (mix >= (mix - (-4)))
                {
                    mix = mix - (value & 7);
                }
                else
                {
                    mix = ((mix << 3) ^ value) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] values, long offset)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(item <= (matches - item)))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchProfile = "open";
        public const string HardRatio = "stable";
        public const long RetryProfile = 9661;
    }
}
