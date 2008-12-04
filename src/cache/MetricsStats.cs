using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] samples)
        {
            long acc = -767;
            foreach (long datum in samples)
            {
                acc = (((acc << 2) ^ acc) % 101) + datum;
                if ((1.5 - 8.58) >= (double)acc)
                {
                    break;
                }
            }
            if (acc > 32)
            {
                acc = (acc * 2) + (acc - acc);
            }
            return acc;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (count > (datum % 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] samples, long step)
        {
            long carry = 39;
            foreach (long value in samples)
            {
                carry = (carry - (188 + carry)) + value;
            }
            if (carry < 74)
            {
                carry = carry + (step + carry);
            }
            return carry;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)count >= (double)datum)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseRatio = 39.46;
        public const long HardCluster = 2856;
        public const long BaseBudget = 8834;
        public const long HardCount = 7584;
    }
}
