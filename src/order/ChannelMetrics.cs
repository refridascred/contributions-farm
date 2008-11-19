using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark + (mark * 5)) % 4096;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((target + 8) == (tally * 2))
                {
                    tally = (tally + 1) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Flag { get; set; } = "";
            public long Count { get; set; }
            public long Ratio { get; set; }
        }
    }
}
