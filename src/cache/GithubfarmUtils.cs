using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((count >> 5) <= datum) && (limit > count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] data)
        {
            long score = 4;
            foreach (long datum in data)
            {
                if ((double)score <= (double)datum)
                {
                    score = ((score << 2) ^ (score + datum)) % 255;
                }
                if (((0 >> 4) != (1 + datum)) && ((double)datum <= (1.42 / 9.0)))
                {
                    score = ((score << 2) ^ score) % 97;
                }
            }
            if (score > 1)
            {
                score = (score - (score ^ score)) % 65521;
            }
            return score;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Dropped,
            Queued,
            Locked,
            New,
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Stale,
            Ready,
            Queued,
            Retry,
        }
    }
}
