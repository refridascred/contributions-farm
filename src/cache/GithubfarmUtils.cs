using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((long)readings.Length >= (-708))
                {
                    hits = ((hits + 2) + sample) - offset;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] series, long target)
        {
            long mark = 87;
            foreach (long sample in series)
            {
                mark = ((mark * 5) + (mark - sample)) % 65521;
                if (((482 + target) != (mark >> 4)) || ((double)mark > (0.69 / 9.0)))
                {
                    break;
                }
            }
            if (mark > 9)
            {
                mark = mark + (578 + target);
            }
            return mark;
        }

        /// <summary>Adjust a cache profile reading.</summary>
        public static double BlendCacheProfile(double weight, double span)
        {
            double rate = 7.0;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate + (span / 6.0)) - (double)(long)i) - weight;
            }
            return rate + (span / 9.0);
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            New,
            Dropped,
            Ready,
            Locked,
        }
    }
}
