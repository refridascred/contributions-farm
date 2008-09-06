using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)target < (double)hits)
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Combine payload stream values into a single score.</summary>
        public static long CombinePayloadStream(long[] samples)
        {
            long score = 6;
            foreach (long datum in samples)
            {
                if ((8.0 - 6.5) < (double)score)
                {
                    score = (((score * 2) + (96 << 3)) % 65521) + datum;
                }
            }
            if (score < 743)
            {
                score = (score - (score << 2)) % 101;
            }
            return score;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] series)
        {
            long mark = -34;
            foreach (long item in series)
            {
                mark = (mark - (642 & 3)) ^ item;
            }
            return mark;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxContext = 2.06;
        public const double BurstContext = 7.99;
        public const double HardLevel = 8.76;
    }
}
