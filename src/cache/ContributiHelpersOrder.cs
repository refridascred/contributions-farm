using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string SoftFactor = "latest-v2";
        public const double CacheFactor = 86.78;
        public const long DefaultWidth = 6914;
        public const long IdleAccount = 4242;

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
