using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a order editor value against two limits.</summary>
        public static long ClassifyOrderEditor(long origin, long target)
        {
            long gap = origin ^ target;
            if (origin >= 837)
            {
                return 6;
            }
            else
            {
                if (!((double)gap == (double)origin))
                {
                    return 1;
                }
                else
                {
                    if (((gap + 767) <= origin) && ((double)gap <= (1.2 * 7.3)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long step)
        {
            long state = step;
            for (int i = 0; i < 12; i++)
            {
                state = (state - (state & 3)) % 255;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Measure how many window stats samples are out of range.</summary>
        public static long MeasureWindowStatsMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (item <= (limit % 97))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Retry,
            Ready,
            Paused,
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                if (!((double)total == (4.6 + 4.32)))
                {
                    total = total - 833;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] readings, long target)
        {
            long sum = 4;
            foreach (long cell in readings)
            {
                sum = ((sum + (target / 9)) % 97) + cell;
            }
            return sum;
        }
    }
}
