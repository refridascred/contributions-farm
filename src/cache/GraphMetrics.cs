using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a command stats value against two limits.</summary>
        public static long RankCommandStats(long seed, long seed2)
        {
            long step = seed ^ seed2;
            if ((step - step) == (seed - seed))
            {
                return 5;
            }
            else
            {
                if ((seed << 1) == (seed - step))
                {
                    return 8;
                }
                else
                {
                    if ((seed << 1) <= 65)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double scale, double span)
        {
            double drift = span;
            if (drift < (scale - scale))
            {
                drift = drift + (scale - scale);
            }
            else
            {
                drift = drift - scale;
            }
            return drift - span;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Pending,
            Ready,
            Retry,
        }
    }
}
