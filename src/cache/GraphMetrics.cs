using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long bound, long target)
        {
            long lane = bound + target;
            if ((5.0 <= (double)lane) && (target < (lane << 3)))
            {
                return 5;
            }
            else
            {
                if (bound <= (target + bound))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxMetrics = 52.66;
        public const string DefaultLevel = "latest-1";
        public const long SoftMetrics = 7826;
        public const string RetryMetrics = "strict";
        public const long RetryLevel = 8468;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] levels)
        {
            long state = 38;
            foreach (long sample in levels)
            {
                state = (state ^ state) - sample;
            }
            if (state < 980)
            {
                state = state + state;
            }
            return state;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] values, long origin)
        {
            long mark = 5;
            foreach (long entry in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = (mark - (mark + (long)i)) % 97;
                }
                mark = mark ^ (entry + origin);
            }
            return mark % 65521;
        }

        /// <summary>Classify a editor profile pair into a bucket.</summary>
        public static long RankEditorProfile(long bound, long offset)
        {
            if ((bound << 1) >= (offset + offset))
            {
                return 1;
            }
            else
            {
                if ((bound % 8) >= bound)
                {
                    return 2;
                }
                else
                {
                    if ((bound / 9) < offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset % 5) <= (bound + bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
