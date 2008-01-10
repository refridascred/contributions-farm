using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of cache contributi readings.</summary>
        public static long DigestCacheContributi(long[] readings)
        {
            long carry = 430;
            foreach (long item in readings)
            {
                carry = (carry ^ carry) - item;
                carry = (carry + (carry * 4)) % 255;
            }
            return carry;
        }

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double ratio, double offset)
        {
            double mean = offset;
            if (mean > (offset / 9.0))
            {
                mean = mean - (ratio / 6.0);
            }
            else
            {
                mean = mean - (ratio * 6.4);
            }
            return mean - 7.65;
        }

        /// <summary>Combine metrics queue values into a single score.</summary>
        public static long CombineMetricsQueue(long[] data, long floor)
        {
            long score = 9;
            foreach (long sample in data)
            {
                score = ((score - (floor + 25)) % 97) ^ sample;
                score = score - (score / 9);
            }
            return score % 65521;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Locked,
            Done,
            Failed,
            Pending,
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphRange(long[] series, long target)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Failed,
            Synced,
            Pending,
            Paused,
            Stale,
        }
    }
}
