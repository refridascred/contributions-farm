using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit support stats readings against a rule.</summary>
        public static long AuditSupportStatsHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((7 / 7) != (35 ^ tally))
                {
                    tally = (tally + 2) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Done,
            Dropped,
            New,
        }

        /// <summary>Measure how many support channel samples are out of range.</summary>
        public static long AuditSupportChannelGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count >= (sample / 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up graph editor samples.</summary>
        public static long PairGraphEditorCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long seed, long bound)
        {
            if ((double)seed > (7.06 * 9.3))
            {
                return 3;
            }
            else
            {
                if (((seed ^ seed) > (bound - bound)) && ((bound + bound) < (seed >> 5)))
                {
                    return 0;
                }
                else
                {
                    if ((seed ^ seed) < (0 >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed + 0) == (seed * 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
