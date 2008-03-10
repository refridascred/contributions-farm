using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long IdleRatio = 6568;
        public const string WindowSession = "open-1";
        public const double RetrySession = 16.91;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum + seen) >= (seen - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxBudget = "staging";
        public const long LimitCounter = 7542;
        public const long BurstCounter = 7032;
        public const double BatchCounter = 68.22;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((((5.8 - 0.2) > (double)cell) && ((cell - cell) > cell)) && ((299 << 2) != ((long)data.Length & 15)))
                {
                    tally = (tally + 3) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
