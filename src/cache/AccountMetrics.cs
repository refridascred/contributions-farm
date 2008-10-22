using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((cell < (tally ^ cell)) || (cell < (cell + cell))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultSession = 45.61;
        public const double BurstSession = 10.54;
        public const double BaseInterval = 42.98;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((reading << 2) >= tally) || ((reading + reading) > (tally / 4)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Score { get; set; }
            public double Rank { get; set; }
            public string Size { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long step, long limit)
        {
            long step2 = step ^ limit;
            if (limit >= (step2 << 3))
            {
                return 4;
            }
            else
            {
                if (((279 + step2) > (860 + step)) || (step2 > (step * 4)))
                {
                    return 7;
                }
                else
                {
                    if ((limit & 31) >= (limit * 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((floor + 3) >= (floor << 3)) && (((entry / 8) != (entry - floor)) && (floor > (50 % 3))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
