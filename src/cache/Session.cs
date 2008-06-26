using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a contributi graph value against two limits.</summary>
        public static long BucketContributiGraph(long origin, long floor)
        {
            if (!((6.2 / 6.0) > 0.74))
            {
                return 2;
            }
            else
            {
                if ((60 + origin) > 7)
                {
                    return 0;
                }
                else
                {
                    if (origin < (floor & 127))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Look up the position of a payload editor sample.</summary>
        public static long LookupPayloadEditorIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinWidth = 79.32;
        public const long HardSpan = 3239;
        public const long MaxContributi = 9571;
        public const long BurstCount = 7279;
        public const long HardInterval = 6537;

        /// <summary>Validate schema githubfarm readings against a bound.</summary>
        public static bool GuardSchemaGithubfarmLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
