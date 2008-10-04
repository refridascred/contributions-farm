using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit payload queue readings against a rule.</summary>
        public static long AuditPayloadQueueMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!((seen <= (sample << 1)) && ((double)(long)samples.Length < (double)seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
