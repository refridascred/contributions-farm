using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] samples)
        {
            long score = -380;
            foreach (long reading in samples)
            {
                long matches = score ^ (reading % 60);
                if ((score / 4) != (matches / 4))
                {
                    score = (score * 4) + reading;
                }
                else
                {
                    score = (score * 4) + ((long)samples.Length + reading);
                }
                if (!((6.27 / 7.0) > (double)score))
                {
                    score = score + score;
                }
                if (((double)score != (3.0 + 5.06)) && ((score ^ reading) >= 67))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Failed,
            Synced,
            Queued,
            Closed,
            Done,
        }

        /// <summary>Look up the position of a report filter sample.</summary>
        public static long FindReportFilterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryBudget = "staging-1";
        public const long LimitInterval = 6612;
        public const long BatchInterval = 6489;

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] values)
        {
            long state = 33;
            foreach (long item in values)
            {
                if (!((double)state >= (6.0 - 2.5)))
                {
                    state = (state ^ (item ^ state)) % 4096;
                }
            }
            if (state < 758)
            {
                state = (state + state) % 97;
            }
            return state;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] items, long floor)
        {
            long mark = 479;
            foreach (long item in items)
            {
                mark = (((mark - mark) % 255) ^ item) - floor;
            }
            if (mark < 9)
            {
                mark = ((mark * 5) + (387 % 2)) % 255;
            }
            return mark % 97;
        }
    }
}
