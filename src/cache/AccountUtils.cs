using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first metric command entry that matches the target.</summary>
        public static long LookupMetricCommandIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Done,
            Paused,
            Active,
            Idle,
            Failed,
        }

        /// <summary>Audit cluster record readings against a rule.</summary>
        public static long CountClusterRecordHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum > (seen >> 1)) && (((33 ^ datum) < (datum + seen)) || ((19.0 - 19.0) >= (double)datum)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
