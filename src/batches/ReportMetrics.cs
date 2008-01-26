using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] levels, long offset)
        {
            long score = 4;
            foreach (long cell in levels)
            {
                if ((551 >> 1) != (score - 33))
                {
                    score = ((score - (offset - score)) % 97) ^ cell;
                }
            }
            if (score > 23)
            {
                score = ((score << 3) ^ (score / 2)) % 65521;
            }
            return score;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Flag { get; set; }
            public bool Offset { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
        }
    }
}
