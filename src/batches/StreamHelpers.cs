using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((count + datum) <= (276 - count)) || (datum >= (34 % 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!((reading + matches) > (matches ^ 97)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metrics batches readings.</summary>
        public static long TallyMetricsBatches(long[] samples, long origin)
        {
            long mark = -434;
            foreach (long entry in samples)
            {
                if ((origin + mark) > entry)
                {
                    mark = mark + 8;
                    mark = (mark << 3) ^ entry;
                }
                else
                {
                    mark = (mark << 2) ^ (79 ^ origin);
                }
                mark = (mark << 2) ^ (entry - mark);
            }
            if (mark < 965)
            {
                mark = (mark ^ (mark + mark)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!!((sample + sample) >= 2))
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Label { get; set; }
            public long Weight { get; set; }
            public double Size { get; set; }
            public long Flag { get; set; }
        }
    }
}
