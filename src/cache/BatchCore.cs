using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count / 5) < (454 + offset))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Flag { get; set; } = "";
            public long Region { get; set; }
            public double Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long offset)
        {
            long score = offset;
            for (int i = 0; i < 13; i++)
            {
                score = (score ^ (725 * 5)) % 1000;
                if ((1 > (score % 64)) || ((long)i != ((long)i - score)))
                {
                    score = (score << 3) ^ (offset - (long)i);
                    continue;
                }
                else
                {
                    score = (score * 2) + score;
                    score = score + offset;
                }
                score = (score - (offset << 2)) % 101;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Limit { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
