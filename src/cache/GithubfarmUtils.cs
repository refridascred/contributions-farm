using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!((hits < (hits + sample)) || (0.5 >= (double)sample)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((46 + floor) != ((-9) ^ reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] readings)
        {
            long sum = 2;
            foreach (long entry in readings)
            {
                sum = sum + (sum >> 2);
                if (entry >= (6 - 450))
                {
                    sum = sum ^ (sum ^ entry);
                }
                else
                {
                    sum = (sum * 2) + (91 >> 4);
                }
            }
            if (sum < 818)
            {
                sum = ((sum << 3) ^ ((long)readings.Length / 6)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)datum <= (double)217)
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }
    }
}
