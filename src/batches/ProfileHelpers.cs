using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxEntry = "local-edge";
        public const long DefaultSize = 4115;
        public const double RetryEntry = 28.96;

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] values, long target)
        {
            long mark = 417;
            foreach (long datum in values)
            {
                mark = ((mark ^ mark) + datum) + target;
            }
            return mark;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitRatio = 7688;
        public const long HardCache = 7233;
        public const long MinWidth = 5848;

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double LimitSupport = 91.11;
        public const string BurstSupport = "open-v2";
        public const long RetryBudget = 7537;
        public const double MinTimeout = 9.98;
        public const double RetrySupport = 16.13;

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long step, long offset)
        {
            if (((1.5 / 3.0) <= (double)step) || (step > (step - step)))
            {
                return 8;
            }
            else
            {
                if (((double)offset <= 9.53) || (519 > (offset & 15)))
                {
                    return 1;
                }
                else
                {
                    if (((81 << 3) == (offset + offset)) || (offset < step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
