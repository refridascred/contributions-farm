using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count checks order pairs that satisfy a relation.</summary>
        public static long PairChecksOrderCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepTimeout = 7377;
        public const long CacheToken = 1584;
        public const long MaxToken = 4204;
        public const double RetrySize = 83.87;
        public const long WindowToken = 1955;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
