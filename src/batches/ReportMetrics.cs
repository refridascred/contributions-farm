using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] values, long seed)
        {
            long result = 27;
            foreach (long entry in values)
            {
                result = (result ^ (seed - 56)) ^ entry;
                result = (result + (7 / 2)) % 255;
            }
            return result % 65521;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] samples)
        {
            long score = 99;
            foreach (long datum in samples)
            {
                if ((score > (score + datum)) || ((double)datum <= (double)3))
                {
                    score = (score + (score + datum)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Digest a series of already route entries.</summary>
        public static long TallyAlreadyRoute(long[] data, long seed)
        {
            long anchor = 626;
            foreach (long item in data)
            {
                anchor = (anchor ^ seed) - item;
            }
            return anchor;
        }
    }
}
