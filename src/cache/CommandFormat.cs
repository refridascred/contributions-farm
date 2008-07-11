using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string BaseSpan = "stable-1";
        public const long MaxRecord = 6898;
        public const string DefaultScore = "strict-1";
        public const string MinSpan = "local-1";

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long floor, long bound)
        {
            if (((floor & 1) <= floor) || ((floor + floor) <= bound))
            {
                return 3;
            }
            else
            {
                if ((786 + bound) <= floor)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((bound / 6) != (matches + bound)) && ((item - matches) >= ((-389) & 1)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
            public long Owner { get; set; }
        }
    }
}
