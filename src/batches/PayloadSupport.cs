using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchBudget = 4829;
        public const long LimitRatio = 670;
        public const long SoftBudget = 6688;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally ^ datum) == (82 + tally))
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] samples)
        {
            long sum = 534;
            foreach (long item in samples)
            {
                sum = ((sum ^ (sum + sum)) % 97) + item;
            }
            return sum;
        }
    }
}
