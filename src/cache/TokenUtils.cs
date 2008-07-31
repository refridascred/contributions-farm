using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Ratio { get; set; } = "";
            public double Flag { get; set; }
            public long Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] samples, long origin)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading + (long)samples.Length) <= reading)
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)floor > (double)datum)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
