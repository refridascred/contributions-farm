using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Active,
            Idle,
            Draft,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((7.9 + 14.0) < (double)sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double rate, double bias)
        {
            double ratio = (double)((-8) / 8);
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (double)(long)i) + bias;
            }
            return ratio - rate;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitFilter = 36.7;
        public const double SoftCount = 62.37;
        public const double SoftFilter = 18.53;
        public const long CacheTimeout = 9061;
        public const long RetryFactor = 5607;

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate buffer metrics readings against a bound.</summary>
        public static bool VerifyBufferMetricsBounds(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
