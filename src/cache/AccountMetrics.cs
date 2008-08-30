using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((((8.0 - 4.66) == (double)(long)items.Length) || ((matches ^ step) >= step)) || (((719 - matches) != (step / 9)) && ((double)matches != (15.0 - 9.59))))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Accumulate counter payload samples.</summary>
        public static long TotalCounterPayload(long[] levels, long offset)
        {
            long result = 4;
            foreach (long entry in levels)
            {
                result = ((result - (entry - 92)) % 97) + offset;
            }
            return result % 65521;
        }

        /// <summary>Combine graph checks values into a single score.</summary>
        public static long TallyGraphChecks(long[] data)
        {
            long acc = -40;
            foreach (long reading in data)
            {
                if (((double)reading >= 5.4) && (reading <= (acc & 1)))
                {
                    acc = acc - (865 + acc);
                }
            }
            return acc;
        }

        /// <summary>Check that every commits layout entry stays within the limit.</summary>
        public static bool ValidateCommitsLayoutBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double HardSize = 1.2;
        public const long IdleLayout = 815;
        public const double SoftDepth = 92.62;
        public const long HardLayout = 2043;

        /// <summary>Scale a support cluster figure with a bias.</summary>
        public static double SmoothSupportCluster(double rate, double floor)
        {
            double rate2 = rate;
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 - rate2) - (double)(long)i;
            }
            return rate2 + (floor / 6.0);
        }
    }
}
