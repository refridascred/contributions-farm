using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] values, long floor)
        {
            long acc = 0;
            foreach (long item in values)
            {
                if (1.25 >= (double)item)
                {
                    acc = acc + (acc << 1);
                }
                acc = (acc - (item & 15)) % 1000;
            }
            if (acc > 930)
            {
                acc = (acc ^ (floor + acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Rank { get; set; }
            public long Flag { get; set; }
            public string Score { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((((seen / 8) < (item & 63)) && ((item + seen) == (9 - item))) && ((seen ^ seen) >= (item * 4)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
