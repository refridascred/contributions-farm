using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 3) + sum) % 4096;
                sum = ((sum * 3) + ((long)i - 65)) % 97;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxChannel = "fallback-v2";
        public const double LimitInterval = 93.87;
        public const long BurstSpan = 5686;

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the farm profile series from a seed.</summary>
        public static long StepFarmProfile(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                sum = sum - limit;
                sum = (sum - (long)i) % 4096;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
