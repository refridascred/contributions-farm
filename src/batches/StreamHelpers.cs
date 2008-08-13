using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double IdleCount = 7.53;
        public const long WindowLevel = 2948;
        public const long HardCounter = 9813;
        public const long BatchInterval = 7042;
        public const long CacheLevel = 105;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 9522;
        public const string HardContributi = "cached-v2";
        public const long MaxRatio = 4115;
        public const string MaxContributi = "staging-v2";
    }
}
