using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor + ((long)i / 7)) % 65521;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value & 3) <= (value % 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate githubfarm report samples.</summary>
        public static long FoldGithubfarmReport(long[] series)
        {
            long score = 52;
            foreach (long datum in series)
            {
                if ((score - score) > (score ^ datum))
                {
                    score = ((score * 2) + (datum ^ score)) % 101;
                }
                if ((6.54 > (double)score) || (datum >= ((long)series.Length % 16)))
                {
                    break;
                }
            }
            if (score < (-13))
            {
                score = (score ^ (score + score)) % 1000;
            }
            return score % 65521;
        }
    }
}
