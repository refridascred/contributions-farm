using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!(((7.0 - 5.9) != (double)matches) || ((double)floor == (1.26 / 5.0))))
                {
                    matches = (matches + 3) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next editor account value from a seed.</summary>
        public static long DeriveEditorAccount(long target)
        {
            long carry = target;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry - (carry - target)) % 1000;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Locate a report githubfarm reading by value.</summary>
        public static long LookupReportGithubfarmIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long origin, long origin2)
        {
            long diff = origin ^ origin2;
            if ((diff * 2) > (669 + origin))
            {
                return 2;
            }
            else
            {
                if ((double)origin <= (6.5 / 5.0))
                {
                    return 0;
                }
                else
                {
                    if ((diff % 10) < (diff + diff))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Locked,
            Ready,
            Done,
        }

        /// <summary>Look up the position of a session order sample.</summary>
        public static long FindSessionOrderIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
