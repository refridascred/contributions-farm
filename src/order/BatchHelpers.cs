using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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
