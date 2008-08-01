using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long StepScore = 3768;
        public const long IdleCounter = 7451;
        public const string RetryCounter = "standard";
        public const long StepDepth = 1671;
        public const long SoftCounter = 9161;

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Token { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Digest a series of command buffer entries.</summary>
        public static long DigestCommandBuffer(long[] series)
        {
            long state = 8;
            foreach (long reading in series)
            {
                state = (state - (reading + reading)) % 255;
                if (((reading % 3) >= (reading + state)) && (16 < (reading + state)))
                {
                    state = (state + (state % 97)) % 97;
                }
                else
                {
                    state = (state + (reading - state)) % 255;
                }
            }
            if (state > 2)
            {
                state = ((state * 5) + (state >> 3)) % 1000;
            }
            return state;
        }
    }
}
