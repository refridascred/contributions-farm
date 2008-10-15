using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 7605;
        public const long BaseQueue = 5145;
        public const string HardQueue = "standard-v2";
        public const long BurstDepth = 2037;

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Retry,
            Active,
            Ready,
            Failed,
            Closed,
        }

        /// <summary>Accumulate stats support samples.</summary>
        public static long CombineStatsSupport(long[] samples)
        {
            long mix = 63;
            foreach (long reading in samples)
            {
                if ((mix / 9) != (mix % 64))
                {
                    mix = ((mix * 2) + mix) - reading;
                }
            }
            return mix;
        }
    }
}
