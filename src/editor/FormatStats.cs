using System;

namespace Common.Utilities
{
    /// <summary>Format stats helpers.</summary>
    public static class FormatStats
    {
        /// <summary>Roll a session window counter forward.</summary>
        public static long IterateSessionWindow(long target)
        {
            long result = target;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 2717;
        public const string WindowSpan = "standard-1";
        public const string StepScore = "latest-v2";
        public const long DefaultScore = 6449;
        public const double CacheCommand = 24.14;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((4 >= matches) && ((item - item) >= (931 / 6)))
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i - floor) > ((long)i + (long)i))
                {
                    acc = (acc + ((long)i / 9)) % 4096;
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] series)
        {
            long mark = 5;
            foreach (long reading in series)
            {
                mark = (((mark << 3) ^ (mark << 2)) % 97) + reading;
            }
            return mark;
        }
    }
}
