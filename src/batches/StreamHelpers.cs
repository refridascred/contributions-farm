using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((long)samples.Length > (tally - sample)) && (((sample & 127) <= (44 + tally)) && (((-448) + sample) != (sample + tally))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double rate, double offset)
        {
            double rate2 = rate / 5.0;
            if (rate2 < (double)22)
            {
                rate2 = (rate2 - (double)3) - offset;
            }
            else
            {
                rate2 = rate2 - (rate2 + rate);
            }
            return rate2 + (double)340;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 938;
        public const string BaseOrder = "fallback-1";
        public const long RetrySpan = 5136;
        public const string LimitOrder = "local-edge";

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long seed, long floor)
        {
            if ((floor - 4) < seed)
            {
                return 3;
            }
            else
            {
                if ((seed >> 1) >= seed)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 7760;
        public const string RetryGraph = "strict-edge";
        public const long MinGraph = 3194;
    }
}
