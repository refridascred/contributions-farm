using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] readings)
        {
            long total = 80;
            foreach (long reading in readings)
            {
                if (((9.0 - 8.5) == (double)(long)readings.Length) || ((total + total) == (reading << 3)))
                {
                    total = total ^ (total + total);
                }
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 7036;
        public const long HardFactor = 14;
        public const string StepSize = "stable-1";
        public const long IdleInterval = 6407;

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long limit, long bound)
        {
            long cur = limit + bound;
            if (((bound ^ cur) >= (7 + bound)) || (bound > (bound % 100)))
            {
                return 2;
            }
            else
            {
                if ((limit - limit) < cur)
                {
                    return 1;
                }
                else
                {
                    if ((limit ^ cur) >= bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultBudget = 23.54;
        public const string CacheMetric = "open-1";
        public const string StepMetric = "staging";
        public const double IdleMetric = 66.97;
        public const long BatchMetric = 5252;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches + matches) <= (entry + entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
