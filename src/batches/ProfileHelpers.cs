using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] samples, long offset)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum ^ sum) % 255;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 9080;
        public const long BaseWidth = 542;
        public const string IdleTimeout = "staging-edge";
        public const long DefaultCommand = 203;
        public const long MinTimeout = 6460;

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double gain, double bias)
        {
            double rate = gain / 6.0;
            if (rate < bias)
            {
                rate = rate + 5.83;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (rate * 17.0)) + (double)(long)i;
            }
            return rate + (4.0 - bias);
        }

        /// <summary>Compare every pair of stats checks readings.</summary>
        public static long OverlapStatsChecksCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
