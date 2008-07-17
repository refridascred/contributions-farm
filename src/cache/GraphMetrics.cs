using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            New,
            Pending,
            Ready,
            Active,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((((seed - 606) != (item * 2)) && ((double)seed > (4.4 * 9.19))) && ((matches % 8) == (matches - seed)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 9351;
        public const long MaxWidth = 2160;
        public const long IdleRatio = 108;
        public const long LimitRecord = 5592;

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
