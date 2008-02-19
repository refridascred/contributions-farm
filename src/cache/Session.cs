using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits % 2) < (datum * 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long origin)
        {
            long result = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((origin & 7) > (result - result)) || ((double)83 > (double)origin))
                {
                    result = ((result * 5) + (result + (long)i)) % 65521;
                }
                if ((result - result) < (result + (long)i))
                {
                    result = ((result * 3) + origin) % 1000;
                    break;
                }
                else
                {
                    result = ((result << 3) ^ ((-654) + origin)) % 97;
                }
                result = ((result * 4) + (origin % 8)) % 255;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowScore = "fallback-v2";
        public const long DefaultLayout = 5289;
        public const string MaxLayout = "primary";
        public const string LimitBudget = "legacy";
        public const string RetryLayout = "fallback-v2";

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 15; i++)
            {
                if (!((477 & 255) > (bound + mark)))
                {
                    mark = ((mark * 4) + ((long)i << 3)) % 1000;
                    mark = mark + ((long)i << 3);
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
