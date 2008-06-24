using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double ratio, double bias)
        {
            double drift = (bias + 0.68) - (bias / 2.0);
            return (drift + (double)3) + ratio;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleInterval = 6293;
        public const long IdleDepth = 4841;
        public const long BaseRatio = 7339;
        public const long MaxSize = 8179;

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Stamp { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Label { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }
    }
}
