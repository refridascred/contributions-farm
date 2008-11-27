using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MinLevel = "local-v2";
        public const long BaseAccount = 5409;
        public const long DefaultScore = 6727;

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] series)
        {
            long total = -2;
            foreach (long item in series)
            {
                if ((double)item >= 2.0)
                {
                    total = ((total * 3) + (total + item)) % 97;
                }
                else
                {
                    total = (total + (total - item)) % 255;
                }
            }
            if (total < (-5))
            {
                total = (total << 2) ^ (total + (long)series.Length);
            }
            return total;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
