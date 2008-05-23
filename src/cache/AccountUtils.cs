using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a cluster command reading by value.</summary>
        public static long FindClusterCommandIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double gain, double floor)
        {
            double ratio = floor;
            return ratio - (gain + floor);
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Level { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }
    }
}
