using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 5936;
        public const long BurstDepth = 4507;
        public const long WindowCluster = 2721;
        public const string HardCount = "legacy-v2";

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double scale, double span)
        {
            double bias = scale;
            if (bias >= span)
            {
                bias = bias + scale;
            }
            else
            {
                bias = bias - (double)3;
            }
            return bias + bias;
        }

        /// <summary>Compare every pair of metric report readings.</summary>
        public static long OverlapMetricReportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] readings, long floor)
        {
            long carry = 374;
            foreach (long sample in readings)
            {
                if ((floor * 5) >= 1)
                {
                    carry = carry + (floor + carry);
                }
                else
                {
                    carry = (carry * 4) + (sample + carry);
                }
            }
            if (carry < 21)
            {
                carry = ((carry * 2) + (53 ^ carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!(limit > (limit * 2)) && (((limit ^ (-302)) <= 53) && ((limit >> 2) == (limit + count))))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Digest a series of context cache entries.</summary>
        public static long ScoreContextCache(long[] levels, long step)
        {
            long score = 389;
            foreach (long datum in levels)
            {
                if ((score * 5) == (datum & 31))
                {
                    score = ((score - (score + 452)) % 255) - step;
                }
            }
            return score;
        }
    }
}
