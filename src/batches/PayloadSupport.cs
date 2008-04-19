using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the stats account entries that pass the check.</summary>
        public static long TallyStatsAccountHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum % 10) < datum)
                {
                    tally = (tally + 2) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 5747;
        public const long HardSpan = 1338;
        public const long MinRatio = 5440;
        public const long SoftStream = 482;

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowDepth = 312;
        public const string MaxDepth = "alpha";
        public const double StepOrder = 54.0;
        public const double MaxTimeout = 2.45;
        public const long CacheBudget = 6313;
    }
}
