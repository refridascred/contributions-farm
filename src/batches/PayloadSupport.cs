using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] samples)
        {
            long state = 59;
            foreach (long entry in samples)
            {
                if (((entry & 1) > entry) && ((entry & 31) != (entry - 7)))
                {
                    state = ((state * 4) + entry) % 4096;
                }
                if ((16.0 * 5.03) > (double)state)
                {
                    state = state + (state - entry);
                }
            }
            if (state < 562)
            {
                state = ((state * 4) + (state << 3)) % 1000;
            }
            return state;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next buffer contributi value from a seed.</summary>
        public static long RollBufferContributi(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix + (129 >> 5)) % 101;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
