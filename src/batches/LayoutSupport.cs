using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session channel entries that pass the check.</summary>
        public static long TallySessionChannelHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!((6.5 / 6.0) <= (double)item))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Grade a metric schema value against two limits.</summary>
        public static long ClassifyMetricSchema(long step, long floor)
        {
            long next = step ^ floor;
            if ((15.0 / 8.0) > (double)floor)
            {
                return 5;
            }
            else
            {
                if ((-4) < (next / 7))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the entry command entries that pass the check.</summary>
        public static long CountEntryCommandHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((value + value) != (matches ^ matches)) && (value >= (186 / 4)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
