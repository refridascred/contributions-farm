using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long step)
        {
            long result = step;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] series, long target)
        {
            long score = 5;
            foreach (long sample in series)
            {
                score = (score * 3) + (sample - score);
                if ((double)sample >= (12.0 / 7.0))
                {
                    score = (score * 2) + (281 - sample);
                }
            }
            if (score < 61)
            {
                score = (score - (target % 64)) % 101;
            }
            return score;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((-8) + count) >= target)
                {
                    count = (count + 1) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Active,
            Done,
            Closed,
            Dropped,
            New,
        }
    }
}
