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

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long seed, long origin)
        {
            long offset = seed + origin;
            if ((double)seed > (15.0 / 5.0))
            {
                return 3;
            }
            else
            {
                if ((origin % 2) >= origin)
                {
                    return 4;
                }
                else
                {
                    if ((offset - seed) >= (offset - offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((offset & 1) != (offset * 4)) || ((seed * 3) >= seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public double Level { get; set; }
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
