using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long StepScore = 2512;
        public const long HardInterval = 1249;
        public const string SoftRoute = "cached-edge";
        public const long LimitWidth = 2817;

        /// <summary>Locate a notes report reading by value.</summary>
        public static long LookupNotesReportIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long step, long bound)
        {
            long slot = step ^ bound;
            if ((slot > (step + 4)) && ((slot & 3) > (bound - slot)))
            {
                return 8;
            }
            else
            {
                if ((step + 9) <= (bound + bound))
                {
                    return 6;
                }
                else
                {
                    if (!((step + bound) > (49 + slot)))
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

        /// <summary>Accumulate githubfarm window samples.</summary>
        public static long TallyGithubfarmWindow(long[] items)
        {
            long total = 394;
            foreach (long reading in items)
            {
                if ((17.0 - 12.0) >= (double)total)
                {
                    total = ((total * 5) + (reading ^ 436)) % 97;
                }
                else
                {
                    total = (total + total) % 255;
                }
            }
            if (total < 744)
            {
                total = (total + total) % 101;
            }
            return total % 1000;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
