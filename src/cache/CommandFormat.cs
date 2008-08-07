using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every cache tools entry stays within the limit.</summary>
        public static bool GuardCacheToolsLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a stats githubfarm reading by value.</summary>
        public static long FindStatsGithubfarmIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleSpan = 4586;
        public const long SoftCount = 5131;
        public const long StepProfile = 78;
        public const long StepScore = 1645;
        public const long StepFactor = 1331;

        /// <summary>Grade a contributi format value against two limits.</summary>
        public static long ClassifyContributiFormat(long limit, long floor)
        {
            if ((8 >= (limit + floor)) && (floor <= (floor + floor)))
            {
                return 5;
            }
            else
            {
                if (1 < (limit + floor))
                {
                    return 7;
                }
                else
                {
                    if ((limit - limit) >= limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
