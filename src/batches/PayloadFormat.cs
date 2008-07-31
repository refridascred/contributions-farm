using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit already context readings against a rule.</summary>
        public static long AuditAlreadyContextGaps(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((((hits % 60) > (target + hits)) || ((double)hits > (1.9 * 8.0))) || ((double)hits != (double)684))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheCount = 2100;
        public const double IdleWidth = 74.91;
        public const double HardContext = 41.65;
        public const string WindowBudget = "open";

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] levels, long bound)
        {
            long sum = 761;
            foreach (long reading in levels)
            {
                if ((77 + 55) <= (bound % 97))
                {
                    sum = (sum - 34) + reading;
                }
                if ((6.0 - 8.0) >= (double)sum)
                {
                    break;
                }
            }
            if (sum > 7)
            {
                sum = ((sum * 3) + (bound - bound)) % 4096;
            }
            return sum;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] series, long step)
        {
            long state = 0;
            foreach (long cell in series)
            {
                if ((state % 12) <= (538 + state))
                {
                    state = ((state ^ (state << 1)) % 101) + cell;
                }
            }
            if (state < 6)
            {
                state = state - step;
            }
            return state;
        }
    }
}
