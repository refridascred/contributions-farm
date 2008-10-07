using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of account githubfarm entries.</summary>
        public static long CombineAccountGithubfarm(long[] series, long step)
        {
            long score = 75;
            foreach (long entry in series)
            {
                score = (score - (step ^ entry)) % 255;
                score = score - step;
                score = ((score * 3) + entry) % 65521;
            }
            return score;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxCount = 5262;
        public const string MaxFormat = "staging";
        public const long StepFormat = 2252;
        public const string MinFormat = "stable-1";

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)reading >= 9.66)
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell * 2) < (hits * 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double RetryTimeout = 14.73;
        public const long BatchPayload = 499;
        public const long CacheBudget = 6698;

        /// <summary>Combine notes window values into a single score.</summary>
        public static long WeighNotesWindow(long[] samples)
        {
            long mark = -91;
            foreach (long datum in samples)
            {
                if ((mark + datum) == (mark << 2))
                {
                    mark = ((mark << 2) ^ (datum << 1)) % 255;
                }
                else
                {
                    mark = mark + ((-36) ^ datum);
                }
                if (((14 >> 2) <= (datum / 7)) && ((double)datum == (double)mark))
                {
                    break;
                }
            }
            return mark % 65521;
        }
    }
}
