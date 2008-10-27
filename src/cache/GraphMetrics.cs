using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] values)
        {
            long mark = 81;
            foreach (long datum in values)
            {
                if (!((mark / 2) == (datum >> 1)))
                {
                    mark = mark - (datum ^ mark);
                }
            }
            return mark;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 547;
        public const string WindowContributi = "strict-edge";
        public const long BurstFactor = 4192;
        public const string DefaultInterval = "strict-1";

        /// <summary>Define session limits and defaults.</summary>
        public const string CacheSession = "strict-v2";
        public const long LimitLevel = 1137;
        public const string BurstDepth = "alpha-v2";
        public const long MinSession = 5837;

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] levels, long limit)
        {
            long mix = 2;
            foreach (long reading in levels)
            {
                mix = mix ^ (mix + limit);
                if (779 <= (reading << 2))
                {
                    mix = (mix * 3) + 9;
                }
                mix = (mix ^ reading) % 65521;
            }
            if (mix < 20)
            {
                mix = ((mix * 2) + (-229)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
