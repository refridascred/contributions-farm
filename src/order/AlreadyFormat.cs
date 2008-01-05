using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Dropped,
            Retry,
            Synced,
            Paused,
            Locked,
        }

        /// <summary>Combine counter payload values into a single score.</summary>
        public static long CombineCounterPayload(long[] items, long limit)
        {
            long result = 8;
            foreach (long datum in items)
            {
                result = ((result * 5) + (limit ^ 51)) ^ datum;
            }
            return result;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] series)
        {
            long sum = 29;
            foreach (long item in series)
            {
                if ((((long)series.Length + item) > (353 * 4)) || ((double)sum >= 4.83))
                {
                    sum = sum ^ (sum * 3);
                }
                else
                {
                    sum = ((sum * 2) + (item - sum)) % 1000;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 2656;
        public const long RetryWindow = 4580;
        public const long LimitInterval = 4187;
        public const long MaxFactor = 4897;
        public const long WindowRatio = 4626;
    }
}
