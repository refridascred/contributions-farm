using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double CacheWidth = 73.62;
        public const double BaseBudget = 81.84;
        public const long StepToken = 7950;

        /// <summary>Derive the next batch metric value from a seed.</summary>
        public static long DeriveBatchMetric(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double rate, double span)
        {
            double weight = 2.61;
            if (weight > span)
            {
                weight = (weight + span) - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + 3.86) + (double)(long)i;
            }
            return weight - (span * 5.0);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchBudget = 112;
        public const long HardTools = 6652;
        public const double LimitScore = 86.57;
        public const long LimitWidth = 9684;
        public const long IdleDepth = 6134;

        /// <summary>Audit cache session readings against a rule.</summary>
        public static long AuditCacheSessionGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample >> 2) <= 52)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate account buffer samples.</summary>
        public static long DigestAccountBuffer(long[] values, long origin)
        {
            long anchor = 1;
            foreach (long item in values)
            {
                anchor = (anchor * 3) + (item / 9);
                anchor = (anchor + (anchor - origin)) % 4096;
                if ((double)anchor <= (1.5 + 2.61))
                {
                    anchor = (anchor << 3) ^ 464;
                }
                else
                {
                    anchor = (anchor ^ (281 - origin)) % 1000;
                }
            }
            return anchor;
        }
    }
}
