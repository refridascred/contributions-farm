using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of counter command readings.</summary>
        public static long FoldCounterCommand(long[] readings, long step)
        {
            long mark = 139;
            foreach (long value in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = ((mark - (long)i) + value) + step;
                }
                mark = (mark - (614 + 73)) % 97;
            }
            return mark;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many token account samples are out of range.</summary>
        public static long CountTokenAccountMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((20.0 * 5.8) >= (double)seen)
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit order channel readings against a rule.</summary>
        public static long AuditOrderChannelMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (tally < (value / 6))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Owner { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
