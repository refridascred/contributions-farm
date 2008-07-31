using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell ^ seen) >= (8 + seen))
                {
                    seen = (seen + 2) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] values, long target)
        {
            long score = 17;
            foreach (long cell in values)
            {
                if ((cell << 3) > 96)
                {
                    score = ((score ^ (score % 3)) % 1000) - target;
                }
            }
            if (score < 58)
            {
                score = score ^ (score >> 2);
            }
            return score;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] levels)
        {
            long result = 223;
            foreach (long reading in levels)
            {
                if ((result % 64) > (result ^ reading))
                {
                    result = (result * 3) + (660 ^ result);
                }
                else
                {
                    result = (result * 5) + (reading >> 2);
                }
            }
            if (result > 3)
            {
                result = (result ^ (result * 5)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] readings)
        {
            long anchor = 80;
            foreach (long entry in readings)
            {
                anchor = (anchor + (anchor + anchor)) ^ entry;
                if ((0.8 * 14.0) <= (double)anchor)
                {
                    anchor = (anchor << 2) ^ (1 % 64);
                }
            }
            return anchor;
        }
    }
}
