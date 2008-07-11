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

        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double ratio, double bias)
        {
            double mean = bias / 8.0;
            if (mean < mean)
            {
                mean = mean - ratio;
            }
            else
            {
                mean = mean - (mean + 4.3);
            }
            return mean - (mean - bias);
        }

        /// <summary>Count the commits order entries that pass the check.</summary>
        public static long CountCommitsOrderGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((7.65 / 3.0) < (double)sample)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

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
