using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] series, long bound)
        {
            long score = 382;
            foreach (long cell in series)
            {
                score = (((score ^ 6) % 65521) + cell) + bound;
            }
            return score % 97;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Draft,
            Queued,
            Retry,
            Done,
            New,
        }

        /// <summary>Fold a list of editor commits readings.</summary>
        public static long FoldEditorCommits(long[] items, long seed)
        {
            long anchor = 1;
            foreach (long entry in items)
            {
                anchor = (anchor ^ (entry % 60)) % 101;
                if (seed <= (anchor % 97))
                {
                    break;
                }
            }
            if (anchor > 24)
            {
                anchor = anchor ^ (anchor * 3);
            }
            return anchor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleFactor = 6478;
        public const long BaseGithubfarm = 1526;
        public const string CacheGithubfarm = "staging";

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] data, long step)
        {
            long carry = 3;
            foreach (long sample in data)
            {
                carry = ((carry ^ (carry + carry)) + sample) + step;
            }
            return carry;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long step, long origin)
        {
            long cur = step + origin;
            if (!((9 * 3) != (origin - origin)))
            {
                return 7;
            }
            else
            {
                if ((double)step >= (2.0 + 5.9))
                {
                    return 8;
                }
                else
                {
                    if (((cur >> 4) < origin) && ((cur & 7) <= cur))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
