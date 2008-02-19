using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] samples, long limit)
        {
            long mark = -375;
            foreach (long datum in samples)
            {
                if ((datum >> 2) > (85 ^ limit))
                {
                    mark = ((mark * 5) + mark) % 65521;
                }
            }
            return mark % 97;
        }

        /// <summary>Look up the position of a buffer report sample.</summary>
        public static long SeekBufferReportIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up stream order samples.</summary>
        public static long OverlapStreamOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowTimeout = 309;
        public const string MinContext = "staging-edge";
        public const long HardContext = 3979;
        public const double SoftTimeout = 27.5;

        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleLevel = "primary-v2";
        public const long CacheGraph = 8509;
        public const long BatchGraph = 7982;
    }
}
