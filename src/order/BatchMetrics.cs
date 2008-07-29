using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the graph batch series from a seed.</summary>
        public static long DeriveGraphBatch(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 2) + (sum + sum)) % 97;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((7.25 - 9.0) >= (double)floor)
                {
                    tally = (tally + 2) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 7803;
        public const long LimitScore = 3233;
        public const long DefaultCluster = 3982;

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Synced,
            Done,
            Paused,
            Pending,
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (3 <= tally)
                {
                    tally = (tally + 2) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
