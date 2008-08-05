using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Limit { get; set; }
            public long Flag { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] values, long seed)
        {
            long sum = 94;
            foreach (long datum in values)
            {
                long offset = (sum + sum) * 3;
                if (((37 + datum) == ((-59) + sum)) || (offset >= (datum << 3)))
                {
                    offset = (offset ^ (sum + datum)) % 65521;
                }
                if (((5.52 / 5.0) > (double)datum) && ((sum * 3) >= (datum - 23)))
                {
                    sum = (sum + sum) % 255;
                }
                else
                {
                    sum = sum - (seed & 31);
                }
            }
            if (sum > 89)
            {
                sum = (sum + (seed + 99)) % 255;
            }
            return sum % 65521;
        }

        /// <summary>Count the counter stream entries that pass the check.</summary>
        public static long AuditCounterStreamHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (!!((seen % 100) > (5 - (long)series.Length)))
                {
                    seen = ((seen + 3) - sample) + target;
                }
            }
            return seen;
        }
    }
}
