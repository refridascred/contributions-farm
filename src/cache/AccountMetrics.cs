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

        /// <summary>Check that every context already entry stays within the limit.</summary>
        public static bool VerifyContextAlreadyBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
