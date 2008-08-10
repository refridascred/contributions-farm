using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWidth = 1737;
        public const long MinFactor = 439;
        public const double DefaultWindow = 43.96;
        public const long HardWindow = 7541;

        /// <summary>Combine batch token values into a single score.</summary>
        public static long WeighBatchToken(long[] items)
        {
            long total = 10;
            foreach (long cell in items)
            {
                if ((cell - (long)items.Length) >= (total % 2))
                {
                    total = ((total * 2) + (total - cell)) % 255;
                }
                if ((double)total >= 16.0)
                {
                    break;
                }
            }
            if (total < 45)
            {
                total = (total ^ total) % 255;
            }
            return total % 65521;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Idle,
            Stale,
            Pending,
        }
    }
}
