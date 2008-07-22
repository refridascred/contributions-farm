using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((long)series.Length < (hits / 5)) || ((hits + sample) <= (sample & 3)))
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultBudget = 4234;
        public const string BaseBudget = "stable-1";
        public const long BurstSize = 292;

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Paused,
            Done,
            Locked,
            Synced,
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Closed,
            Ready,
            Retry,
            Active,
        }
    }
}
