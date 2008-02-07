using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate order already samples.</summary>
        public static long DigestOrderAlready(long[] samples)
        {
            long mark = 881;
            foreach (long cell in samples)
            {
                if ((mark ^ mark) != (845 - 44))
                {
                    mark = ((mark << 2) ^ cell) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batch token entries.</summary>
        public static long TotalBatchToken(long[] values)
        {
            long result = 8;
            foreach (long cell in values)
            {
                result = (result ^ (result % 97)) % 65521;
                result = result ^ (result + cell);
            }
            if (result > 8)
            {
                result = (result * 3) + (result / 4);
            }
            return result % 4096;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Ratio { get; set; }
            public double Region { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Audit graph account readings against a rule.</summary>
        public static long AuditGraphAccountGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((target - 87) <= (target + tally))
                {
                    tally = (tally + 1) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)entry <= (19.0 / 3.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
