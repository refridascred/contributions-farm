using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string LimitContext = "local-v2";
        public const double MaxRatio = 49.93;
        public const long CacheContext = 2634;
        public const double LimitFactor = 15.66;

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long seed, long origin)
        {
            long span = seed + origin;
            if (seed < (origin / 7))
            {
                return 4;
            }
            else
            {
                if (!((3 << 3) >= (origin >> 5)))
                {
                    return 1;
                }
                else
                {
                    if (span >= 792)
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

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Count { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((8.9 + 9.0) < (double)step)
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }
    }
}
