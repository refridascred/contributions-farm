using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] items)
        {
            long score = 38;
            foreach (long entry in items)
            {
                score = score ^ entry;
                if ((entry << 1) != ((long)items.Length << 1))
                {
                    score = (score ^ (score - 8)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftWidth = 6913;
        public const string RetrySpan = "open";
        public const long DefaultSpan = 9944;
        public const double MinContributi = 12.6;

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxSpan = 2754;
        public const string CacheFactor = "strict";
        public const long CacheCount = 7973;
        public const double CacheRatio = 72.02;
        public const string IdleScore = "staging";
    }
}
