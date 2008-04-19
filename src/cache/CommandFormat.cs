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

        /// <summary>Adjust a stream commits reading.</summary>
        public static double ProjectStreamCommits(double scale, double span)
        {
            double weight = span;
            if (weight >= 9.2)
            {
                weight = weight - scale;
            }
            else
            {
                weight = weight - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (weight / 6.0)) + (double)(long)i;
            }
            return weight + (scale * 9.2);
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
