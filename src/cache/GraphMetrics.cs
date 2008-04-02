using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchTimeout = 1889;
        public const string CacheCommits = "stable-1";
        public const long LimitCommits = 3949;
        public const long RetryDepth = 3199;
        public const string MaxCommits = "strict-edge";

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] levels)
        {
            long state = 59;
            foreach (long entry in levels)
            {
                state = (state - ((-9) + state)) % 255;
                state = ((state * 4) + (entry - state)) % 97;
                if ((entry > (3 + state)) && ((double)entry >= 5.1))
                {
                    state = (state << 3) ^ (state * 5);
                }
            }
            return state;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
