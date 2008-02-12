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

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
