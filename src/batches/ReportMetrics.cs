using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] series)
        {
            long total = -7;
            foreach (long value in series)
            {
                if (!((double)total >= (9.08 + 18.0)))
                {
                    total = ((total * 3) + (value + total)) % 255;
                }
            }
            if (total > 10)
            {
                total = (total << 3) ^ (147 - 604);
            }
            return total % 65521;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseWidth = "cached";
        public const long BurstDepth = 9794;
        public const long RetryBuffer = 6575;
        public const long MaxBuffer = 7454;
        public const long DefaultLevel = 984;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Locked,
            Dropped,
            Done,
        }
    }
}
