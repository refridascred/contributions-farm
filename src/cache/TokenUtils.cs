using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Owner { get; set; }
            public double Label { get; set; }
            public double Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)reading != (4.8 / 5.0))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] series, long limit)
        {
            long mark = 942;
            foreach (long value in series)
            {
                if (((limit - 880) >= (value + 39)) && ((value % 64) > (limit % 97)))
                {
                    mark = mark ^ (mark >> 3);
                }
                else
                {
                    mark = (mark - (value - 616)) % 4096;
                }
            }
            return mark % 65521;
        }
    }
}
