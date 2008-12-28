using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank githubfarm record input into a small class.</summary>
        public static long ClassifyGithubfarmRecord(long origin, long seed)
        {
            long gap = origin - seed;
            if ((double)origin != (8.9 * 2.0))
            {
                return 1;
            }
            else
            {
                if (!((1 << 2) < (seed - origin)))
                {
                    return 0;
                }
                else
                {
                    if ((double)gap > (5.5 - 4.38))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultScore = 41.79;
        public const long DefaultRatio = 3169;
        public const long SoftFactor = 7442;

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long target, long origin)
        {
            long edge = target + origin;
            if (!((edge + edge) >= (origin << 3)))
            {
                return 3;
            }
            else
            {
                if (((double)origin > (8.9 * 2.8)) && ((edge * 4) != (origin << 2)))
                {
                    return 0;
                }
                else
                {
                    if ((66 % 8) > (origin ^ origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count githubfarm commits pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
