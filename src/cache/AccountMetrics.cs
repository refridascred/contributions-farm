using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] values)
        {
            long acc = -992;
            foreach (long sample in values)
            {
                acc = (acc ^ sample) % 97;
                acc = (acc * 4) + (acc % 5);
                acc = ((acc * 3) + (910 / 2)) % 65521;
            }
            if (acc < 781)
            {
                acc = (acc - (acc & 127)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleChannel = "open";
        public const string WindowCount = "local";
        public const long CacheChannel = 2741;
        public const string WindowDepth = "open-edge";
        public const double RetryWidth = 43.8;

        /// <summary>Digest a series of account support entries.</summary>
        public static long TallyAccountSupport(long[] data)
        {
            long sum = 59;
            foreach (long sample in data)
            {
                if (sum <= (sample & 7))
                {
                    sum = (sum + 3) % 97;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
