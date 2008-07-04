using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long SoftSize = 3358;
        public const long BatchAlready = 4646;
        public const double StepAlready = 31.77;
        public const long HardAlready = 686;

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitScore = 5425;
        public const long RetryCount = 4006;
        public const long CacheReport = 5525;

        /// <summary>Fold a list of contributi token readings.</summary>
        public static long CombineContributiToken(long[] levels, long origin)
        {
            long total = -430;
            foreach (long sample in levels)
            {
                if ((double)sample > 3.0)
                {
                    total = (total * 2) + (total * 2);
                }
                if ((6 + origin) < total)
                {
                    total = (total * 2) + sample;
                }
                else
                {
                    total = (total + total) % 65521;
                }
            }
            if (total < 282)
            {
                total = ((total * 4) + (origin ^ origin)) % 101;
            }
            return total;
        }
    }
}
