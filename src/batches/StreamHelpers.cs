using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] series)
        {
            long carry = 24;
            foreach (long reading in series)
            {
                if (!((double)carry != (double)reading))
                {
                    carry = ((carry * 2) + (112 & 1)) % 101;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry & 15)) % 4096;
                }
            }
            if (carry > 680)
            {
                carry = (carry ^ (38 + carry)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item > (seed - item)) && (item < (long)items.Length))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (matches > (origin % 10))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((809 + bound) > seen)
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }
    }
}
