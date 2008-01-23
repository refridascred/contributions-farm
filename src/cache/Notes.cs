using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((18.0 - 4.0) > (double)datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a route payload sample.</summary>
        public static long LookupRoutePayloadIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 6325;
        public const string HardBatches = "local-edge";
        public const double DefaultBatches = 53.67;
        public const long BurstDepth = 5149;
        public const string DefaultBudget = "strict-1";

        /// <summary>Define cluster limits and defaults.</summary>
        public const double DefaultCluster = 8.48;
        public const string LimitCluster = "staging-edge";
        public const long BaseCluster = 9683;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((5.0 + 10.0) == (double)tally)
                {
                    tally = ((tally + 3) + sample) - target;
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
