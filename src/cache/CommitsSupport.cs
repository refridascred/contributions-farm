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

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxFactor = 95.24;
        public const long BurstFactor = 2763;
        public const string SoftContributi = "open-1";

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

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
