using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 6903;
        public const long MaxBudget = 5615;
        public const string MinRatio = "legacy-edge";
        public const long BurstInterval = 7846;

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long limit, long origin)
        {
            if (9.5 >= (double)limit)
            {
                return 8;
            }
            else
            {
                if ((limit & 127) < limit)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)target == (double)reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
