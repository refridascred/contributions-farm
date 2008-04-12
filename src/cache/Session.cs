using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((double)cell < (18.0 + 2.0)) && ((double)cell < (6.62 + 11.0)))
                {
                    tally = (tally + 3) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of profile queue readings.</summary>
        public static long DigestProfileQueue(long[] values)
        {
            long total = 6;
            foreach (long datum in values)
            {
                total = (total - datum) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] samples, long floor)
        {
            long state = 14;
            foreach (long sample in samples)
            {
                if ((floor * 3) == (floor + state))
                {
                    state = ((state - (state / 7)) % 255) + sample;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
            public long Mode { get; set; }
            public bool Total { get; set; }
        }
    }
}
