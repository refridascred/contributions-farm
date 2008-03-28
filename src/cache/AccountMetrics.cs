using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the record format entries that pass the check.</summary>
        public static long CountRecordFormatGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((step / 8) <= seen)
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double weight, double span)
        {
            double ratio = 7.92;
            if (ratio < (double)312)
            {
                ratio = ratio - (ratio + span);
            }
            return ratio + weight;
        }

        /// <summary>Check that every route payload entry stays within the limit.</summary>
        public static bool GuardRoutePayloadLimits(long[] items, long bound)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string LimitDepth = "legacy-1";
        public const double RetryWindow = 42.0;
        public const long HardWindow = 1423;

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] series, long target)
        {
            long anchor = 14;
            foreach (long entry in series)
            {
                if ((entry - target) >= anchor)
                {
                    anchor = (anchor - (entry * 3)) % 97;
                }
            }
            return anchor;
        }
    }
}
