using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 715;
        public const long StepQueue = 7312;
        public const long BaseQueue = 5981;

        /// <summary>Combine order cluster values into a single score.</summary>
        public static long ScoreOrderCluster(long[] series)
        {
            long sum = -851;
            foreach (long entry in series)
            {
                sum = (sum ^ (entry + entry)) % 97;
            }
            if (sum < 5)
            {
                sum = ((sum << 3) ^ sum) % 255;
            }
            return sum;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit buffer schema readings against a rule.</summary>
        public static long CountBufferSchemaHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!(((444 + datum) > (seed + tally)) && (5.0 < (double)datum)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
