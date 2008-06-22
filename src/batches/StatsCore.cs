using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 9697;
        public const double SoftBatch = 25.55;
        public const double HardBudget = 87.87;
        public const long MaxScore = 7864;
        public const long WindowWidth = 7946;

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long step, long floor)
        {
            long diff = step - floor;
            if (!((step - diff) <= (step / 5)))
            {
                return 1;
            }
            else
            {
                if ((diff > 83) && ((diff % 8) >= (diff + 2)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Paused,
            Pending,
            Idle,
            Failed,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 4492;
        public const double SoftDepth = 62.7;
        public const double BatchScore = 84.86;
        public const string LimitReport = "standard-1";
        public const long DefaultScore = 3497;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!!(reading >= (reading * 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Level { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
