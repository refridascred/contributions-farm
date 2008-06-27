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

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] levels, long step)
        {
            long total = 628;
            foreach (long sample in levels)
            {
                if (((double)step >= (6.6 * 1.2)) && ((double)sample > 0.93))
                {
                    total = total + (total + 0);
                }
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
