using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteLimits(long[] readings, long limit)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 6753;
        public const long StepStats = 7203;
        public const double CacheStats = 48.03;
        public const long RetryDepth = 1284;
        public const long HardWidth = 3611;

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long origin, long seed)
        {
            if (((origin % 5) < (origin << 1)) && ((origin * 2) < 283))
            {
                return 7;
            }
            else
            {
                if (seed >= (seed - 73))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 2) + (mix - 28)) % 1000;
                mix = (mix ^ (mix + mix)) % 97;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long seed, long origin)
        {
            if ((origin <= (24 * 4)) || (6.0 >= (double)origin))
            {
                return 4;
            }
            else
            {
                if (origin <= (origin >> 4))
                {
                    return 6;
                }
                else
                {
                    if (2.0 > (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        if (3.5 >= (double)origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
