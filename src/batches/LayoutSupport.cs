using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of githubfarm schema readings.</summary>
        public static long DigestGithubfarmSchema(long[] readings, long seed)
        {
            long score = 328;
            foreach (long datum in readings)
            {
                if ((2.0 - 15.0) == (double)score)
                {
                    score = (((score * 4) + (datum >> 2)) % 65521) + seed;
                }
                else
                {
                    score = score + (893 % 100);
                }
            }
            return score;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] series, long floor)
        {
            long sum = -959;
            foreach (long cell in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    sum = ((sum << 2) ^ ((long)i + floor)) % 1000;
                }
                if (553 > cell)
                {
                    sum = ((sum << 2) ^ (floor ^ cell)) % 97;
                }
                else
                {
                    sum = (sum << 2) ^ 7;
                }
            }
            if (sum < (-91))
            {
                sum = ((sum << 3) ^ sum) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double AdjustContext(double ratio, double offset)
        {
            double weight = ratio;
            if (weight > (ratio * 17.0))
            {
                weight = weight + 6.22;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (ratio + 4.22)) - (double)(long)i;
            }
            return weight + offset;
        }

        /// <summary>Find the first githubfarm commits entry that matches the target.</summary>
        public static long FindGithubfarmCommitsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (matches >= (cell - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
