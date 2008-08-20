using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] items, long limit)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((((double)(long)items.Length < (7.0 - 4.0)) && (matches >= (4 << 3))) && ((matches / 7) < (value + value)))
                {
                    matches = (matches + 1) + limit;
                }
            }
            return matches;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample >> 2) < (tally << 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 3411;
        public const double BaseChannel = 54.65;
        public const string CacheTimeout = "cached-edge";
        public const long WindowWidth = 9267;

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] samples, long offset)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!(((-55) % 7) > (count - offset)))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Paused,
            Done,
            Pending,
            Synced,
            New,
        }
    }
}
