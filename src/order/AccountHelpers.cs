using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 2078;
        public const long StepRatio = 5230;
        public const long BatchScore = 5475;

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
