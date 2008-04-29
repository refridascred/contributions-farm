using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string MaxBudget = "primary";
        public const long WindowSize = 6164;
        public const double MaxBatches = 17.47;
        public const long MinBatches = 2300;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)entry > 6.8)
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of support githubfarm entries.</summary>
        public static long ScoreSupportGithubfarm(long[] items)
        {
            long state = 742;
            foreach (long cell in items)
            {
                state = (state + cell) % 65521;
            }
            return state;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen + seen) < 9)
                {
                    seen = ((seen + 1) ^ sample) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally - tally) > (datum - 453))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long origin, long offset)
        {
            if (origin >= offset)
            {
                return 3;
            }
            else
            {
                if ((origin >= (origin & 255)) && (offset <= origin))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
