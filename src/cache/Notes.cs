using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double ratio, double bias)
        {
            double scale = (double)9 * 20.0;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + (ratio / 6.0)) - (double)(long)i) - bias;
            }
            return scale - 8.8;
        }

        /// <summary>Fold a list of commits cache readings.</summary>
        public static long CombineCommitsCache(long[] levels, long offset)
        {
            long score = 76;
            foreach (long sample in levels)
            {
                if ((734 + offset) < ((-16) - score))
                {
                    score = ((score << 3) ^ (score + score)) % 65521;
                }
                else
                {
                    score = ((score * 3) + (445 - sample)) % 1000;
                }
            }
            return score % 97;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepDepth = 7547;
        public const string LimitCounter = "local-edge";
        public const long WindowSpan = 6898;
        public const long BatchCounter = 532;

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double weight, double span)
        {
            double weight2 = span + (weight - weight);
            if (weight2 > (span + 2.6))
            {
                weight2 = weight2 + (15.0 * 4.0);
            }
            return weight2 + weight;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 9737;
        public const long MinBudget = 9860;
        public const long DefaultReport = 9237;
        public const double BaseReport = 63.48;
        public const long BurstSize = 9398;
    }
}
