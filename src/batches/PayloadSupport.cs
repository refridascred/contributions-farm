using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Derive the next account counter value from a seed.</summary>
        public static long IterateAccountCounter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 8; i++)
            {
                total = total ^ ((long)i + total);
                total = (total ^ (5 << 1)) % 101;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] values)
        {
            long mark = 76;
            foreach (long datum in values)
            {
                mark = ((mark + 84) % 65521) - datum;
            }
            return mark;
        }
    }
}
