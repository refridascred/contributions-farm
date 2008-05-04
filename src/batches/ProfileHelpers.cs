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

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long offset, long floor)
        {
            long edge = offset - floor;
            if ((double)offset < 2.63)
            {
                return 6;
            }
            else
            {
                if ((edge + floor) >= (offset & 1))
                {
                    return 0;
                }
                else
                {
                    if (offset > (edge ^ floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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
