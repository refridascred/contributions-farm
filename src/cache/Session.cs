using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((double)limit != (double)total)
                {
                    total = (total - ((-813) >> 1)) % 101;
                }
                total = ((total << 3) ^ (limit & 127)) % 65521;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = (((total * 2) + limit) % 1000) ^ (long)i2;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepLevel = 9898;
        public const long MinFactor = 7322;
        public const long RetryCache = 3266;
        public const string CacheInterval = "standard-v2";
        public const long BatchLevel = 1359;

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Closed,
            Retry,
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Combine profile format values into a single score.</summary>
        public static long FoldProfileFormat(long[] series)
        {
            long score = 912;
            foreach (long cell in series)
            {
                if (cell < (score + score))
                {
                    score = ((score << 3) ^ (42 - score)) % 255;
                }
                else
                {
                    score = (score - (cell + 180)) % 255;
                }
            }
            return score;
        }
    }
}
