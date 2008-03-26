using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 5246;
        public const long BatchBuffer = 111;
        public const long StepWidth = 1329;
        public const string LimitBudget = "staging-v2";

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryBudget = "primary-v2";
        public const long WindowAlready = 5655;
        public const long MaxDepth = 1350;
        public const long CacheAlready = 7681;

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] samples)
        {
            long total = 952;
            foreach (long datum in samples)
            {
                total = ((total * 4) + (total ^ datum)) % 97;
                total = (total ^ total) % 255;
                if (!((total + total) == (datum / 8)))
                {
                    total = total ^ 228;
                }
            }
            if (total < 8)
            {
                total = ((total << 2) ^ (total & 127)) % 65521;
            }
            return total % 4096;
        }
    }
}
