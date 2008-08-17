using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally - step) <= tally)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Locked,
            Pending,
            Active,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BurstDepth = 92.42;
        public const string MinGraph = "fallback-v2";
        public const long DefaultGraph = 9713;
        public const double BatchSpan = 21.2;
    }
}
