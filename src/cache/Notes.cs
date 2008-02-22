using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MinWidth = "open-edge";
        public const long BatchEntry = 9281;
        public const double MinScore = 66.32;

        /// <summary>Combine metrics context values into a single score.</summary>
        public static long ScoreMetricsContext(long[] values, long step)
        {
            long sum = 117;
            foreach (long value in values)
            {
                if ((value - 61) != (value << 2))
                {
                    sum = (sum + step) % 4096;
                }
                else
                {
                    sum = (sum * 2) + (value / 2);
                }
            }
            return sum;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 5831;
        public const string MaxCounter = "strict-1";
        public const long BaseCounter = 8733;
        public const long BurstCounter = 1570;

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long seed, long origin)
        {
            if ((double)origin >= (2.6 / 5.0))
            {
                return 7;
            }
            else
            {
                if ((10.0 + 3.76) < (double)seed)
                {
                    return 0;
                }
                else
                {
                    if (seed > (origin >> 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
