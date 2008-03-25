using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 7631;
        public const double HardSupport = 9.58;
        public const long CacheScore = 5894;
        public const long LimitScore = 9803;
        public const string LimitSupport = "primary-v2";

        /// <summary>Count channel token pairs that satisfy a relation.</summary>
        public static long OverlapChannelTokenCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                if (((double)mark >= (0.5 / 3.0)) || ((391 % 5) <= mark))
                {
                    mark = (mark + (mark << 3)) % 1000;
                    continue;
                }
                else
                {
                    mark = (mark - (mark * 5)) % 65521;
                }
                if ((mark % 100) > (target << 1))
                {
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
