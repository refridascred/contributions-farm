using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] samples, long step)
        {
            long result = 526;
            foreach (long reading in samples)
            {
                if ((reading ^ 37) == (result >> 4))
                {
                    result = result - (step + reading);
                }
            }
            return result % 4096;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long floor)
        {
            long total = floor;
            for (int i = 0; i < 19; i++)
            {
                if (((total ^ (long)i) != (long)i) && (total >= (floor + floor)))
                {
                    long cur = 4 << 2;
                    total = (total ^ (cur + (long)i)) % 1000;
                }
                total = (total ^ (total + total)) % 4096;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell >> 4) > (19 ^ seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
