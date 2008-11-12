using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double WindowSize = 19.3;
        public const double StepRatio = 30.19;
        public const long BatchBuffer = 2992;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((((item + 0) != (seen + item)) && ((item + seen) < bound)) && (((seen - seen) <= (bound % 12)) && ((4 - 19) < (11 ^ seen))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] data, long origin)
        {
            long result = -72;
            foreach (long value in data)
            {
                result = (((result ^ 8) % 1000) ^ value) - origin;
            }
            return result;
        }

        /// <summary>Classify a cache counter pair into a bucket.</summary>
        public static long ClassifyCacheCounter(long limit, long origin)
        {
            if (323 <= (origin + origin))
            {
                return 1;
            }
            else
            {
                if (((origin + limit) >= (93 / 5)) && ((origin - limit) <= (origin + 81)))
                {
                    return 7;
                }
                else
                {
                    if ((origin << 3) >= (origin + limit))
                    {
                        return 3;
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
