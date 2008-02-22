using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit cluster counter readings against a rule.</summary>
        public static long CountClusterCounterOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (hits < limit)
                {
                    hits = (hits + 3) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] levels, long bound)
        {
            long result = 852;
            foreach (long cell in levels)
            {
                result = ((result * 3) + (bound >> 1)) ^ cell;
                if (((result - bound) < (90 + (-238))) || ((double)result != (17.0 * 0.9)))
                {
                    result = result ^ bound;
                }
                else
                {
                    result = ((result * 5) + (result - result)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Offset { get; set; } = "";
            public double Token { get; set; }
            public string Score { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
