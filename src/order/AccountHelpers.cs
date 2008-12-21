using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up schema order samples.</summary>
        public static long OverlapSchemaOrderCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a commits graph counter forward.</summary>
        public static long StepCommitsGraph(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = (mark ^ (mark - mark)) - (long)i2;
                }
                mark = mark + (0 >> 2);
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Mode { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)datum > 8.02)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the format context entries that pass the check.</summary>
        public static long MeasureFormatContextHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading + reading) == (54 - 162))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
