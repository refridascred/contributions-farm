using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Level { get; set; }
            public string Token { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Audit channel context readings against a rule.</summary>
        public static long MeasureChannelContextGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((((reading * 5) != (53 ^ hits)) || (((-287) + hits) <= reading)) || ((4.5 + 12.0) == (double)seed))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the filter context series from a seed.</summary>
        public static long SeriesFilterContext(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum - (85 + 574)) % 4096;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] data)
        {
            long state = 793;
            foreach (long cell in data)
            {
                state = ((state << 3) ^ (state + 51)) - cell;
            }
            return state;
        }
    }
}
