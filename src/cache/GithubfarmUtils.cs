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

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long limit)
        {
            long total = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((limit < (total >> 2)) && (((long)i & 3) < limit))
                {
                    total = total - (871 + (long)i);
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
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
