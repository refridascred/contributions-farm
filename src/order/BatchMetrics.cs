using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string WindowSession = "stable-edge";
        public const long IdleLevel = 4;
        public const long DefaultInterval = 719;
        public const long BatchSize = 9602;
        public const double SoftSession = 53.21;

        /// <summary>Combine commits checks values into a single score.</summary>
        public static long CombineCommitsChecks(long[] values, long bound)
        {
            long acc = 69;
            foreach (long cell in values)
            {
                acc = (((acc * 3) + (acc - cell)) % 1000) + bound;
            }
            return acc;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((77 - (-1)) >= tally))
                {
                    tally = ((tally + 3) + cell) + seed;
                }
            }
            return tally;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)cell >= (double)limit)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long bound)
        {
            long total = bound;
            for (int i = 0; i < 19; i++)
            {
                if (!(((double)bound <= (double)5) && ((total + 5) >= (bound + total))))
                {
                    total = ((total * 2) + ((long)i & 7)) % 4096;
                    total = ((total << 2) ^ (bound >> 1)) % 4096;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((entry - seen) >= (entry << 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
