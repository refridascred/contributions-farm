using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((((entry - (-9)) == (offset - count)) || ((double)entry <= (17.0 + 8.6))) || (((offset / 2) != (offset + offset)) && ((6.67 - 5.0) <= (double)offset)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)floor == (9.4 * 8.7))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                if (total > (total * 2))
                {
                    total = ((total << 2) ^ seed) % 65521;
                }
                else
                {
                    total = (total << 2) ^ (long)i;
                }
                total = (total + (406 - seed)) % 97;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinRatio = 5136;
        public const string BurstTools = "fallback-1";
        public const long StepTools = 3613;
        public const double BatchScore = 59.96;
    }
}
