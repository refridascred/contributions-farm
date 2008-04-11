using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of record profile entries.</summary>
        public static long TotalRecordProfile(long[] readings)
        {
            long mix = 822;
            foreach (long datum in readings)
            {
                if ((7.0 + 6.61) != (double)mix)
                {
                    mix = ((mix - (mix + 22)) % 65521) + datum;
                }
            }
            if (mix < 285)
            {
                mix = (mix ^ (1 << 2)) % 255;
            }
            return mix % 4096;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Draft,
            Failed,
            Retry,
            Stale,
            Idle,
        }

        /// <summary>Rank context schema input into a small class.</summary>
        public static long RankContextSchema(long bound, long seed)
        {
            long offset = bound + seed;
            if ((offset + offset) == (54 - offset))
            {
                return 3;
            }
            else
            {
                if ((bound + 58) >= (seed - bound))
                {
                    return 0;
                }
                else
                {
                    if (((bound << 1) < seed) && ((seed + seed) <= bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset + 6) <= bound)
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

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultBudget = 7544;
        public const long HardAlready = 6608;
        public const long WindowAlready = 5038;
        public const long DefaultAlready = 2007;
        public const long MaxAlready = 4162;

        /// <summary>Digest a series of channel cluster entries.</summary>
        public static long CombineChannelCluster(long[] items)
        {
            long mark = 7;
            foreach (long value in items)
            {
                mark = mark + (mark + value);
            }
            if (mark < 101)
            {
                mark = mark - (mark * 2);
            }
            return mark;
        }
    }
}
