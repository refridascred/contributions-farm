using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] series, long target)
        {
            long anchor = -9;
            foreach (long value in series)
            {
                if ((7 + anchor) > anchor)
                {
                    anchor = ((anchor << 3) ^ (anchor ^ value)) % 65521;
                }
                else
                {
                    anchor = (anchor ^ (target << 3)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseWidth = 5556;
        public const long BaseCounter = 2528;
        public const string DefaultFactor = "open-v2";
        public const double BurstScore = 87.0;
        public const long DefaultInterval = 811;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits < (double)entry)
                {
                    hits = (hits + 3) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
