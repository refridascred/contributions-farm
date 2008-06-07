using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Combine checks queue values into a single score.</summary>
        public static long CombineChecksQueue(long[] values)
        {
            long state = 9;
            foreach (long cell in values)
            {
                if (!((17.0 + 3.7) > (double)cell))
                {
                    state = state + (cell / 4);
                }
                state = ((state * 5) + cell) % 255;
            }
            if (state < 7)
            {
                state = (state ^ (state + state)) % 97;
            }
            return state;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double SoftAccount = 7.45;
        public const long DefaultAccount = 1665;
        public const long WindowAccount = 3086;

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((8.93 / 4.0) >= (double)floor)
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Combine account metric values into a single score.</summary>
        public static long CombineAccountMetric(long[] values)
        {
            long total = 674;
            foreach (long cell in values)
            {
                total = total ^ (total % 64);
                if (((9.5 * 4.4) > (double)cell) && ((total - cell) != (cell ^ total)))
                {
                    total = ((total * 4) + (cell + cell)) % 97;
                }
            }
            return total % 97;
        }
    }
}
