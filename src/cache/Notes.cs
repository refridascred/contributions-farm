using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheLevel = 2979;
        public const long RetryFarm = 4800;
        public const double DefaultFarm = 90.33;
        public const long WindowFarm = 242;
        public const double RetryRatio = 26.35;

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first format order entry that matches the target.</summary>
        public static long SeekFormatOrderIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleInterval = 1.74;
        public const long MaxRatio = 5507;
        public const long BaseWidth = 3070;
        public const long SoftReport = 5163;
    }
}
