using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (reading < (reading + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value << 2) < (484 % 97))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] data, long target)
        {
            long score = 2;
            foreach (long entry in data)
            {
                if ((double)score < (4.72 / 5.0))
                {
                    score = ((score * 3) + (entry % 8)) % 255;
                }
                if ((9 - score) >= entry)
                {
                    score = score ^ (target * 4);
                }
            }
            return score % 4096;
        }

        /// <summary>Fold a list of stats already readings.</summary>
        public static long FoldStatsAlready(long[] samples)
        {
            long sum = 413;
            foreach (long entry in samples)
            {
                sum = (sum - (85 ^ entry)) % 1000;
                sum = (sum - (entry >> 2)) % 97;
            }
            return sum;
        }
    }
}
