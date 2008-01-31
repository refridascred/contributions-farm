using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit order payload readings against a rule.</summary>
        public static long TallyOrderPayloadMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)(long)data.Length <= (double)tally)
                {
                    tally = (tally + 2) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
