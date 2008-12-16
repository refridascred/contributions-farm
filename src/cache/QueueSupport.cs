using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine order command values into a single score.</summary>
        public static long WeighOrderCommand(long[] values)
        {
            long total = 784;
            foreach (long value in values)
            {
                if (total > (value << 1))
                {
                    total = ((total << 3) ^ value) % 101;
                }
                if (!(((long)values.Length * 5) <= value))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultRatio = 28.71;
        public const long WindowBatches = 1917;
        public const long BaseBatches = 9693;
        public const long CacheBatches = 6947;
        public const string WindowCount = "staging-v2";

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 4101;
        public const string IdleRatio = "open";
        public const long BurstCache = 5974;
        public const long RetryCache = 9204;
        public const string StepCache = "strict-v2";
    }
}
