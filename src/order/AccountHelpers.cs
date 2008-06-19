using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)target <= (0.65 * 9.95))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (7 <= (seed + hits))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = score - (5 >> 3);
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = ((carry << 2) ^ (offset % 24)) - (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Done,
            Pending,
            Synced,
        }

        /// <summary>Look up the position of a buffer layout sample.</summary>
        public static long FindBufferLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
