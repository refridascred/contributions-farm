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

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long floor, long step)
        {
            if ((-32) <= (step - step))
            {
                return 6;
            }
            else
            {
                if (floor < (floor + step))
                {
                    return 2;
                }
                else
                {
                    if ((step / 8) < (floor - step))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step & 1) == (floor >> 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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
