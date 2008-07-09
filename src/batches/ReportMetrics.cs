using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] samples, long bound)
        {
            long sum = 688;
            foreach (long value in samples)
            {
                if (((bound / 2) == (sum & 31)) || (((long)samples.Length % 8) <= (bound + bound)))
                {
                    sum = ((sum << 2) ^ bound) ^ value;
                }
            }
            if (sum > (-264))
            {
                sum = (sum - bound) % 255;
            }
            return sum % 65521;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardOrder = 27.3;
        public const double BaseLevel = 63.93;
        public const long CacheOrder = 4050;
        public const string WindowBudget = "stable-1";
        public const long WindowSize = 9832;

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Idle,
            Done,
            Queued,
            Failed,
        }
    }
}
