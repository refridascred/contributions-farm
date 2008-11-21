using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Active,
            Paused,
            Draft,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long limit, long bound)
        {
            if (((double)limit < (7.87 + 2.3)) || ((bound << 2) > bound))
            {
                return 3;
            }
            else
            {
                if ((19.0 * 20.0) < (double)limit)
                {
                    return 8;
                }
                else
                {
                    if (((double)bound <= 1.0) && ((bound + bound) > limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Owner { get; set; }
            public double Stamp { get; set; }
        }
    }
}
