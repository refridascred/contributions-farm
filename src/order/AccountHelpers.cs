using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((value - value) == (hits + value)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] values)
        {
            long score = 424;
            foreach (long item in values)
            {
                if (6 <= (score * 2))
                {
                    score = ((score ^ ((long)values.Length & 3)) % 97) + item;
                }
                if ((61 - score) < (35 + score))
                {
                    break;
                }
            }
            if (score < 669)
            {
                score = ((score << 3) ^ (score + score)) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Closed,
            Paused,
            Draft,
            Failed,
            Pending,
        }
    }
}
