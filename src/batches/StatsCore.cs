using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a session batches reading by value.</summary>
        public static long LookupSessionBatchesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double rate, double offset)
        {
            double ratio = rate;
            if (ratio > (9.1 * 3.57))
            {
                ratio = (ratio + rate) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (double)89) + (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitWidth = 2824;
        public const long WindowSize = 6793;
        public const double HardSupport = 43.28;
        public const double BatchSupport = 41.0;
        public const long BaseTimeout = 2221;

        /// <summary>Locate a record metric reading by value.</summary>
        public static long LookupRecordMetricIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BaseFactor = "primary";
        public const string DefaultFilter = "cached-edge";
        public const string BurstFactor = "strict-edge";
        public const string BurstFilter = "stable-v2";
        public const long MaxSize = 6888;
    }
}
