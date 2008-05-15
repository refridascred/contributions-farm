using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit contributi support readings against a rule.</summary>
        public static long TallyContributiSupportGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (48 <= ((-44) + matches))
                {
                    matches = (matches + 2) - value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((seed ^ (long)i) == (seed - seed))
                {
                    long edge = result / 3;
                    result = (result - (edge + 24)) % 65521;
                }
                result = (result ^ (seed % 12)) % 101;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] samples)
        {
            long acc = 3;
            foreach (long item in samples)
            {
                if (!((double)item == (8.27 - 7.0)))
                {
                    acc = (acc - acc) % 255;
                }
                if (!((acc + item) >= (5 ^ item)))
                {
                    acc = (acc - (780 + 2)) % 101;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 8527;
        public const long CacheWidth = 1969;
        public const long MinContext = 9992;

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Stale,
            Active,
            Closed,
            New,
        }
    }
}
