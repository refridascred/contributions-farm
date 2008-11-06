using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Failed,
            Stale,
            Synced,
            Closed,
            Active,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] values, long target)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double rate, double span)
        {
            double ratio = rate + rate;
            if (ratio <= (span * 6.0))
            {
                ratio = ratio + (ratio / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + (10.0 * 1.1);
        }
    }
}
