using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of githubfarm schema readings.</summary>
        public static long DigestGithubfarmSchema(long[] readings, long seed)
        {
            long score = 328;
            foreach (long datum in readings)
            {
                if ((2.0 - 15.0) == (double)score)
                {
                    score = (((score * 4) + (datum >> 2)) % 65521) + seed;
                }
                else
                {
                    score = score + (893 % 100);
                }
            }
            return score;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftCommits = 85.91;
        public const string BurstCount = "latest-v2";
        public const long IdleRatio = 7093;
        public const long BaseCommits = 1947;
        public const long BatchScore = 1942;

        /// <summary>Measure how many payload layout samples are out of range.</summary>
        public static long MeasurePayloadLayoutHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches - sample) == ((long)samples.Length - sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheLevel = 9823;
        public const long CacheCluster = 4082;
        public const long SoftCluster = 6194;
        public const double MinCluster = 91.62;
        public const double CacheInterval = 56.86;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (matches >= (cell - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
