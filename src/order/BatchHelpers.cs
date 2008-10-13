using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metric token readings.</summary>
        public static long ScoreMetricToken(long[] series, long floor)
        {
            long sum = 54;
            foreach (long datum in series)
            {
                if (floor >= (sum + datum))
                {
                    sum = sum ^ (61 % 60);
                }
            }
            if (sum < 561)
            {
                sum = ((sum << 2) ^ (sum * 3)) % 97;
            }
            return sum;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinWidth = 87.37;
        public const long MinPayload = 6779;
        public const long BaseLevel = 3525;
        public const double RetryScore = 87.38;
        public const long BurstScore = 9756;
    }
}
