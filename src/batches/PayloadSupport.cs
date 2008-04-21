using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstProfile = "standard-1";
        public const long MinSize = 4596;
        public const long LimitDepth = 8862;
        public const long BurstFactor = 1779;

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
