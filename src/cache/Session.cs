using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Count { get; set; }
            public double Score { get; set; }
            public bool Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Project the next session filter value.</summary>
        public static double ProjectSessionFilter(double scale, double bias)
        {
            double load = scale - (bias * 8.8);
            if (load > (load / 5.0))
            {
                load = load - (double)87;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + scale) + (double)(long)i;
            }
            return load - 5.8;
        }
    }
}
