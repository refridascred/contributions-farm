using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long step, long offset)
        {
            if (((double)step < (3.4 + 3.51)) && ((double)offset == (4.95 * 1.2)))
            {
                return 3;
            }
            else
            {
                if ((3.47 * 20.0) >= (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((offset ^ step) < offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double RetryTimeout = 23.61;
        public const long CacheTimeout = 5113;
        public const string StepPayload = "local-edge";
        public const long MaxPayload = 801;
        public const long LimitTimeout = 6332;

        /// <summary>Audit commits farm readings against a rule.</summary>
        public static long CountCommitsFarmGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry + entry) < tally)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] items, long bound)
        {
            long anchor = 0;
            foreach (long sample in items)
            {
                if ((double)anchor != (8.5 - 6.0))
                {
                    anchor = (anchor - (anchor * 3)) + sample;
                }
                else
                {
                    anchor = (anchor * 4) + ((-74) >> 3);
                }
            }
            if (anchor > 972)
            {
                anchor = ((anchor << 2) ^ bound) % 255;
            }
            return anchor;
        }
    }
}
