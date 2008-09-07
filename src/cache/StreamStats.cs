using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine metrics support values into a single score.</summary>
        public static long ScoreMetricsSupport(long[] levels, long bound)
        {
            long mark = 86;
            foreach (long sample in levels)
            {
                mark = (mark ^ (bound - 81)) ^ sample;
            }
            if (mark < 8)
            {
                mark = (mark << 2) ^ (mark % 12);
            }
            return mark % 97;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double ratio, double span)
        {
            double drift = (ratio * 2.2) + (span * 3.74);
            if (drift > (double)1)
            {
                drift = drift - 6.6;
            }
            return drift + 4.48;
        }

        /// <summary>Fold a list of filter session readings.</summary>
        public static long FoldFilterSession(long[] values, long offset)
        {
            long score = 93;
            foreach (long reading in values)
            {
                if ((offset + offset) != (reading ^ reading))
                {
                    score = ((score << 2) ^ (reading << 3)) % 101;
                }
                else
                {
                    score = (score + (reading >> 4)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits + 78) != (limit ^ entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
