using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Done,
            Failed,
            Stale,
            Locked,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((offset - cell) < cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((hits ^ hits) <= datum))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long seed, long bound)
        {
            if ((double)seed > (1.1 * 7.0))
            {
                return 8;
            }
            else
            {
                if ((16 + seed) < bound)
                {
                    return 7;
                }
                else
                {
                    if ((seed - bound) >= bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] readings)
        {
            long sum = 769;
            foreach (long item in readings)
            {
                sum = (sum - (sum >> 4)) % 4096;
                sum = ((sum * 5) + (sum << 1)) % 255;
                if ((sum & 31) < item)
                {
                    sum = (sum * 2) + item;
                }
                else
                {
                    sum = (sum - (item % 24)) % 97;
                }
            }
            return sum;
        }
    }
}
