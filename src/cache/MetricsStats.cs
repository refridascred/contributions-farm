using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((11 + matches) > (matches >> 1))
                {
                    matches = ((matches + 3) ^ reading) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((double)matches < (double)reading) || ((double)reading == (double)(-54)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = ((anchor ^ limit) % 97) + (long)i2;
                    anchor = (anchor + (5 * 3)) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
