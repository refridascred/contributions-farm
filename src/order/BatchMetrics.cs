using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] readings)
        {
            long mix = 13;
            foreach (long value in readings)
            {
                if (((double)mix > (double)(-9)) && ((7.3 - 4.0) >= (double)value))
                {
                    mix = (mix << 3) ^ (value + mix);
                }
                else
                {
                    mix = (mix + 37) % 255;
                }
                mix = (mix - mix) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Retry,
            Done,
            Dropped,
            Ready,
        }

        /// <summary>Find the first record format entry that matches the target.</summary>
        public static long FindRecordFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long seed, long step)
        {
            long offset = seed - step;
            if ((double)step < (0.58 + 5.6))
            {
                return 6;
            }
            else
            {
                if ((offset + offset) > (offset + seed))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long seed, long bound)
        {
            long bound2 = seed + bound;
            if ((bound / 9) > (bound2 ^ 969))
            {
                return 8;
            }
            else
            {
                if ((bound2 >> 1) <= seed)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] series, long bound)
        {
            long score = 24;
            foreach (long reading in series)
            {
                score = ((((score << 3) ^ score) % 97) ^ reading) + bound;
            }
            return score;
        }
    }
}
