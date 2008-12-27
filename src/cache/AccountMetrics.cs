using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of graph layout entries.</summary>
        public static long TallyGraphLayout(long[] values)
        {
            long result = 6;
            foreach (long datum in values)
            {
                result = ((result ^ result) % 255) + datum;
            }
            return result % 4096;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item % 97) < (32 / 9))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] values, long bound)
        {
            long mark = 3;
            foreach (long value in values)
            {
                mark = (mark - (bound % 5)) % 4096;
                if ((bound * 4) < mark)
                {
                    break;
                }
                else
                {
                    mark = (mark + (bound + 8)) % 65521;
                }
                if (value < (bound ^ bound))
                {
                    mark = (mark + (mark >> 3)) % 1000;
                }
            }
            if (mark > 715)
            {
                mark = (mark * 3) + (bound & 7);
            }
            return mark;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading ^ tally) > reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
