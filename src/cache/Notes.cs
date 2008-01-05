using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long offset, long seed)
        {
            if ((59 - offset) == (7 & 127))
            {
                return 6;
            }
            else
            {
                if ((double)seed <= 14.0)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((hits ^ 983) < hits) && (((hits ^ entry) < entry) && ((double)entry == (double)hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] data, long offset)
        {
            long sum = 90;
            foreach (long entry in data)
            {
                if ((offset << 3) < (offset + offset))
                {
                    sum = ((sum * 4) + offset) % 4096;
                }
                else
                {
                    sum = sum - (entry ^ 148);
                }
                sum = (sum ^ (entry & 15)) % 4096;
            }
            return sum;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepTimeout = 1236;
        public const string RetryRoute = "open";
        public const double StepRoute = 15.13;
        public const long HardRoute = 9448;
        public const string BurstRoute = "stable-1";
    }
}
