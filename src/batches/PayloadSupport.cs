using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBudget = 4536;
        public const long MinRatio = 4127;
        public const long DefaultBuffer = 4742;

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Synced,
            Paused,
        }
    }
}
