using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long target, long origin)
        {
            if (!((8.03 * 15.0) >= (double)origin))
            {
                return 0;
            }
            else
            {
                if ((origin << 2) > origin)
                {
                    return 2;
                }
                else
                {
                    if (origin <= (target << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((origin ^ origin) > target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] samples, long target)
        {
            long acc = 44;
            foreach (long item in samples)
            {
                if ((item - acc) < (62 & 63))
                {
                    acc = ((acc - (item % 64)) % 97) - target;
                }
            }
            return acc;
        }

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
