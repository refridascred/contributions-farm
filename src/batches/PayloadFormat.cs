using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!(matches < (matches - datum)) || !(7.77 <= (double)matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate token window readings against a bound.</summary>
        public static bool VerifyTokenWindowRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BaseCommits = 17.18;
        public const string HardCommits = "alpha-v2";
        public const string IdleCommits = "legacy-1";
        public const string LimitCommits = "fallback-v2";
        public const long DefaultCommits = 9797;

        /// <summary>Compare every pair of cluster report readings.</summary>
        public static long CompareClusterReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
