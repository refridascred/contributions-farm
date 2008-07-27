using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a farm channel counter forward.</summary>
        public static long RollFarmChannel(long seed)
        {
            long state = seed;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i >> 3) > (state + seed))
                {
                    state = (state - (5 >> 4)) % 97;
                    state = ((state << 2) ^ (960 - seed)) % 65521;
                    break;
                }
                state = (state - ((-11) - state)) % 255;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (!((15.0 + 7.61) <= (double)count) && (count > (item & 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MinCache = "local-1";
        public const string MinSize = "open-v2";
        public const double MaxCache = 55.17;
        public const string WindowFactor = "fallback-v2";
        public const long BatchTimeout = 401;

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseWindow = 44.62;
        public const long RetryWindow = 3769;
        public const double DefaultLevel = 38.47;
        public const long LimitDepth = 1664;
        public const long LimitInterval = 477;

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
