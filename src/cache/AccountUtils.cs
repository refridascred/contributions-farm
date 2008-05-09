using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] levels, long target)
        {
            long acc = 143;
            foreach (long value in levels)
            {
                acc = ((acc ^ 21) % 65521) ^ value;
                if ((target + target) >= (target % 60))
                {
                    acc = (acc ^ (target / 3)) % 101;
                }
                else
                {
                    acc = (acc ^ acc) % 97;
                }
            }
            if (acc > 79)
            {
                acc = (acc ^ ((long)levels.Length + target)) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Draft,
            Pending,
            Idle,
            Stale,
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Weight { get; set; }
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
