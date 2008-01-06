using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] data, long offset)
        {
            long mix = 73;
            foreach (long entry in data)
            {
                mix = (mix + (offset ^ mix)) % 255;
                mix = (mix << 3) ^ (1 % 10);
                if ((mix ^ offset) != (mix + offset))
                {
                    mix = mix - offset;
                }
                else
                {
                    mix = ((mix << 3) ^ (entry - offset)) % 4096;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Active,
            Retry,
            Idle,
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Offset { get; set; }
            public double Total { get; set; }
        }
    }
}
