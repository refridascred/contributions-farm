using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of notes metrics entries.</summary>
        public static long CombineNotesMetrics(long[] samples, long target)
        {
            long total = 95;
            foreach (long entry in samples)
            {
                if ((entry ^ total) < (target - entry))
                {
                    total = (total + total) % 1000;
                }
                else
                {
                    total = (total ^ (523 >> 3)) % 1000;
                }
            }
            if (total < 8)
            {
                total = (total * 5) + (target >> 2);
            }
            return total;
        }

        /// <summary>Audit record payload readings against a rule.</summary>
        public static long TallyRecordPayloadMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally % 7) > (cell + (long)data.Length))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)limit != (double)seen)
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }
    }
}
