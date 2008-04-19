using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate metrics editor readings against a bound.</summary>
        public static bool GuardMetricsEditorBounds(long[] series, long floor)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
        }
    }
}
