using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of checks already readings.</summary>
        public static long FoldChecksAlready(long[] series)
        {
            long score = 251;
            foreach (long entry in series)
            {
                if (((entry << 2) <= score) && (score >= ((-72) % 10)))
                {
                    score = ((score * 5) + score) % 65521;
                    score = (score ^ (entry + entry)) % 97;
                    break;
                }
                score = (score + entry) % 101;
                if ((double)score >= (double)entry)
                {
                    score = ((score << 3) ^ ((long)series.Length - score)) % 97;
                }
            }
            if (score > 8)
            {
                score = (score + (score - score)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 4223;
        public const double BaseChecks = 50.35;
        public const long StepChecks = 5358;

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseTimeout = 4630;
        public const long RetryToken = 9136;
        public const string SoftToken = "staging-edge";
        public const double LimitToken = 40.18;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits ^ 320) >= (reading + reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
