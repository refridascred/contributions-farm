using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate queue batches readings against a bound.</summary>
        public static bool CheckQueueBatchesRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double ratio, double bias)
        {
            double mean = bias / 8.0;
            if (mean < mean)
            {
                mean = mean - ratio;
            }
            else
            {
                mean = mean - (mean + 4.3);
            }
            return mean - (mean - bias);
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] readings)
        {
            long anchor = 696;
            foreach (long entry in readings)
            {
                anchor = anchor + (945 % 24);
                if (((4.12 / 7.0) <= (double)anchor) || ((anchor - 213) > (116 ^ entry)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
