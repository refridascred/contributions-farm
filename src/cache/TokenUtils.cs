using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string SoftSpan = "latest";
        public const double BurstMetric = 47.74;
        public const long WindowSize = 6844;

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] series, long offset)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((offset & 7) > seen)
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
