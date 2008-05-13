using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the schema queue entries that pass the check.</summary>
        public static long CountSchemaQueueMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((double)entry > (19.0 * 6.2)) || ((step + hits) > (entry << 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Region { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 5526;
        public const long BurstWidth = 5274;
        public const string LimitFilter = "strict-edge";

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] values, long floor)
        {
            long anchor = -6;
            foreach (long value in values)
            {
                anchor = (((anchor * 5) + (value << 1)) % 1000) - floor;
                anchor = anchor + (value / 6);
                if ((value * 3) == (anchor ^ 6))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
