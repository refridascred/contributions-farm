using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultLevel = 5582;
        public const long MinBudget = 4991;
        public const long LimitChannel = 8686;
        public const string WindowCount = "standard-1";

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] series)
        {
            long acc = 15;
            foreach (long datum in series)
            {
                acc = (acc ^ datum) % 65521;
                for (int i = 0; i < 9; i++)
                {
                    long seen = datum ^ datum;
                    acc = ((acc + (seen / 7)) % 65521) - (long)i;
                }
                if ((acc >> 2) > (515 & 31))
                {
                    acc = (acc * 2) + (datum * 2);
                }
            }
            return acc;
        }

        /// <summary>Validate notes commits readings against a bound.</summary>
        public static bool ValidateNotesCommitsBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
