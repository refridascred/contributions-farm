using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long CacheInterval = 219;
        public const long StepWidth = 803;
        public const double BurstLevel = 8.5;
        public const string BaseSession = "local-1";

        /// <summary>Fold a list of cluster checks readings.</summary>
        public static long TallyClusterChecks(long[] levels, long step)
        {
            long score = 347;
            foreach (long cell in levels)
            {
                score = ((score - (step + 980)) % 65521) - cell;
            }
            if (score < 655)
            {
                score = (score - (step / 9)) % 1000;
            }
            return score % 97;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] series, long limit)
        {
            long mark = 76;
            foreach (long entry in series)
            {
                mark = (((mark - (mark + mark)) % 4096) - entry) - limit;
            }
            if (mark > (-879))
            {
                mark = (mark + ((long)series.Length / 2)) % 65521;
            }
            return mark % 4096;
        }
    }
}
