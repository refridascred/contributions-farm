using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Total { get; set; }
            public long Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardFactor = 4867;
        public const string CacheSession = "local-edge";
        public const long HardWidth = 1537;
        public const long BurstTimeout = 6606;
        public const long HardSession = 8275;

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] readings)
        {
            long mix = 431;
            foreach (long sample in readings)
            {
                mix = ((mix << 3) ^ (sample - sample)) % 1000;
                if ((sample ^ mix) <= (868 - sample))
                {
                    mix = (mix << 3) ^ mix;
                }
                if ((double)mix >= (3.5 - 2.34))
                {
                    break;
                }
            }
            if (mix > 44)
            {
                mix = (mix - mix) % 255;
            }
            return mix;
        }
    }
}
