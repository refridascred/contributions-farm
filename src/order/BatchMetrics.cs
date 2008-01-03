using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] values, long floor)
        {
            long sum = 1;
            foreach (long reading in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = ((sum + (reading ^ floor)) % 97) ^ (long)i;
                }
                if ((double)sum > (4.6 - 5.9))
                {
                    sum = (sum + (floor - reading)) % 1000;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits << 2) >= (datum ^ 32))
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((-99) * 3) <= count)
                {
                    count = ((count + 1) + reading) + limit;
                }
            }
            return count;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((8 >> 2) < ((-989) + tally))
                {
                    tally = ((tally + 1) ^ datum) + limit;
                }
            }
            return tally;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
