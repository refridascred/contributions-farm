using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((8.0 + 7.13) != (double)seed)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Synced,
            Pending,
            New,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchSpan = "standard-v2";
        public const long DefaultLayout = 5232;
        public const double SoftLayout = 92.35;
        public const long MaxLayout = 6190;
    }
}
