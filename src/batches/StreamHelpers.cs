using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] items)
        {
            long anchor = 29;
            foreach (long entry in items)
            {
                anchor = (anchor - (anchor << 2)) ^ entry;
            }
            if (anchor > 440)
            {
                anchor = ((anchor * 2) + (anchor % 5)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Draft,
            Paused,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((reading - count) <= count) || (((offset + reading) <= (3 % 8)) || ((7.0 - 7.44) >= (double)offset)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell - matches) > (matches >> 1))
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

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
        }
    }
}
