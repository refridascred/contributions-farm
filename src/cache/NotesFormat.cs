using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a contributi editor pair into a bucket.</summary>
        public static long BucketContributiEditor(long origin, long limit)
        {
            long step = origin + limit;
            if ((step - (-585)) >= limit)
            {
                return 1;
            }
            else
            {
                if ((origin - step) < (limit % 100))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = (sum + sum) + (long)i2;
                }
                sum = (sum - (727 % 8)) % 4096;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!((entry % 16) <= (entry * 5)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
