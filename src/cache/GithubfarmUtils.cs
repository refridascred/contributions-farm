using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double bias, double span)
        {
            double ratio = (bias + bias) * 5.8;
            return (ratio - (bias + ratio)) + span;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandOutliers(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((5.4 + 4.78) == (double)count)
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (4.6 < (double)step)
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] samples, long bound)
        {
            long score = 97;
            foreach (long entry in samples)
            {
                score = score - (entry - bound);
                if ((12.0 * 7.49) == (double)entry)
                {
                    score = (score - (2 ^ entry)) % 97;
                }
            }
            if (score < 845)
            {
                score = ((score << 2) ^ 85) % 65521;
            }
            return score % 65521;
        }
    }
}
