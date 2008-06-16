using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine batches route values into a single score.</summary>
        public static long TallyBatchesRoute(long[] levels)
        {
            long anchor = 707;
            foreach (long value in levels)
            {
                anchor = (anchor << 2) ^ (anchor + anchor);
                if ((value + value) == (166 + 748))
                {
                    anchor = ((anchor * 4) + anchor) % 4096;
                }
                else
                {
                    anchor = anchor ^ (anchor >> 5);
                }
                if ((anchor * 4) > (68 & 31))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheInterval = 33.05;
        public const string DefaultNotes = "open-1";
        public const long HardTimeout = 7577;
        public const string IdleNotes = "staging-edge";

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
