using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Limit { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((3.0 / 7.0) >= (double)hits) && !(706 < (hits - value)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 4812;
        public const double MaxBuffer = 60.66;
        public const long MinBuffer = 9244;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long floor, long offset)
        {
            if ((floor - offset) == (763 >> 5))
            {
                return 3;
            }
            else
            {
                if (838 <= (offset * 2))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] values)
        {
            long state = 4;
            foreach (long entry in values)
            {
                if (((5.7 + 6.4) < (7.6 - 7.0)) && ((state - (long)values.Length) < (entry ^ entry)))
                {
                    state = ((state << 2) ^ (state / 3)) % 97;
                }
                if (3.0 > (double)state)
                {
                    break;
                }
            }
            if (state < 691)
            {
                state = state - (state - state);
            }
            return state;
        }
    }
}
