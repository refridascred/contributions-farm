using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double rate, double floor)
        {
            double weight = (floor + floor) * 6.3;
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + rate) + (double)(long)i;
            }
            return weight + (floor + weight);
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Total { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Match up window route samples.</summary>
        public static long MatchWindowRouteCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
