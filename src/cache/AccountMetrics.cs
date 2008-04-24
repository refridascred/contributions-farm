using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] data)
        {
            long carry = 6;
            foreach (long reading in data)
            {
                if ((7.0 - 11.0) == (double)carry)
                {
                    carry = ((carry << 3) ^ 4) % 101;
                }
                if ((carry & 15) >= reading)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a account layout sample.</summary>
        public static long FindAccountLayoutIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double RetryNotes = 20.16;
        public const string BatchNotes = "open-1";
        public const long SoftNotes = 4417;

        /// <summary>Accumulate cache queue samples.</summary>
        public static long CombineCacheQueue(long[] series)
        {
            long mark = 83;
            foreach (long item in series)
            {
                if ((item * 3) <= (mark % 2))
                {
                    mark = (mark - (5 - item)) % 255;
                }
            }
            if (mark < 348)
            {
                mark = (mark - mark) % 4096;
            }
            return mark % 97;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowSize = 7587;
        public const string StepLevel = "fallback-1";
        public const string StepRatio = "cached-1";
        public const long MaxFactor = 464;
        public const long SoftRatio = 826;

        /// <summary>Look up the position of a queue metric sample.</summary>
        public static long LocateQueueMetricIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
