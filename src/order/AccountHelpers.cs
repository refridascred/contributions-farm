using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (50 <= (45 + reading))
                {
                    tally = (tally + 2) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every checks context entry stays within the limit.</summary>
        public static bool ValidateChecksContextRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] readings, long floor)
        {
            long total = 88;
            foreach (long value in readings)
            {
                if (total <= value)
                {
                    total = ((total * 3) + total) % 1000;
                }
                total = total + (95 - floor);
                if (!(((-2) - total) == (floor >> 3)))
                {
                    total = (total ^ (total * 2)) % 1000;
                }
            }
            if (total > 876)
            {
                total = (total * 5) + (floor - 595);
            }
            return total;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Idle,
            Closed,
            Active,
            Done,
            Synced,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double HardSize = 50.08;
        public const long LimitBatch = 6429;
        public const long SoftDepth = 1220;
        public const double HardTimeout = 82.45;
        public const long DefaultBatch = 6520;
    }
}
