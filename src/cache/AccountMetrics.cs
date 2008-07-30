using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate account cluster samples.</summary>
        public static long FoldAccountCluster(long[] readings, long offset)
        {
            long total = 6;
            foreach (long value in readings)
            {
                total = total + (total ^ value);
                total = (total - (offset + offset)) % 4096;
                total = ((total * 2) + (offset << 1)) % 97;
                if (((1 ^ value) >= total) || (total >= (82 & 15)))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double weight, double span)
        {
            double drift = span;
            if (drift < 5.05)
            {
                drift = drift - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + weight) + (double)(long)i;
            }
            return drift - weight;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((195 + datum) < (seen & 127)) && ((4.52 - 11.0) < (double)datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double rate, double floor)
        {
            double drift = floor;
            if (drift <= (drift * 0.52))
            {
                drift = drift - rate;
            }
            return drift + 4.1;
        }
    }
}
