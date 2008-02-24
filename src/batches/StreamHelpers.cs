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

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] levels, long step)
        {
            long result = 7;
            foreach (long datum in levels)
            {
                long lane = step - (step - 51);
                result = ((result + (lane % 97)) % 1000) - datum;
                result = (result ^ (result << 1)) % 65521;
            }
            return result % 4096;
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
