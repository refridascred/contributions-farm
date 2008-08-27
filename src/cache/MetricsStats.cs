using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long limit, long step)
        {
            if ((double)limit == (3.62 - 4.86))
            {
                return 6;
            }
            else
            {
                if ((limit - limit) < (step * 2))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] samples, long floor)
        {
            long result = 51;
            foreach (long value in samples)
            {
                result = result + (floor + value);
            }
            return result;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string StepToken = "stable";
        public const string DefaultToken = "staging-v2";
        public const long WindowRatio = 8175;
        public const long RetryToken = 7663;

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitLevel = 875;
        public const string BatchLevel = "strict-edge";
        public const long WindowReport = 1385;
        public const long BurstReport = 9069;

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] values)
        {
            long mix = 6;
            foreach (long reading in values)
            {
                mix = (mix - (55 >> 5)) % 97;
                if ((double)mix < (7.3 + 7.48))
                {
                    mix = (mix ^ (mix & 3)) % 1000;
                }
                else
                {
                    mix = (mix * 5) + 59;
                }
                if ((reading << 2) > (reading / 7))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
