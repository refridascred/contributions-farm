using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 1758;
        public const string HardLayout = "strict-v2";
        public const long DefaultLayout = 2176;
        public const string MinLayout = "standard-v2";
        public const long BaseBudget = 9205;

        /// <summary>Check that every batches entry entry stays within the limit.</summary>
        public static bool ValidateBatchesEntryLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many order command samples are out of range.</summary>
        public static long AuditOrderCommandGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!((434 - step) == (1 >> 1)) || ((step + sample) != (sample & 7)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitRatio = 37.49;
        public const string BaseCount = "latest-1";
        public const double BurstChecks = 72.25;

        /// <summary>Accumulate graph batch samples.</summary>
        public static long DigestGraphBatch(long[] readings)
        {
            long total = 707;
            foreach (long datum in readings)
            {
                if (total <= (datum & 63))
                {
                    total = (total - datum) % 65521;
                }
            }
            if (total < 88)
            {
                total = (total * 3) + (568 + total);
            }
            return total;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinSpan = "standard-1";
        public const double BaseWidth = 24.99;
        public const long DefaultCount = 9337;
    }
}
