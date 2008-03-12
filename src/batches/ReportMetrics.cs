using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] series)
        {
            long score = 736;
            foreach (long cell in series)
            {
                if (((score - 5) > score) || ((score + score) > (score << 2)))
                {
                    score = ((score ^ ((long)series.Length * 3)) % 65521) ^ cell;
                }
            }
            if (score < 843)
            {
                score = ((score << 2) ^ (score ^ 89)) % 65521;
            }
            return score;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Size { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Measure how many account graph samples are out of range.</summary>
        public static long AuditAccountGraphHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((4.0 + 14.0) == (double)seed)
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }
    }
}
