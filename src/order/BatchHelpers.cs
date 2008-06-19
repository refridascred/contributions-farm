using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BatchTimeout = "stable-edge";
        public const long SoftStream = 3750;
        public const string BaseStream = "alpha-1";

        /// <summary>Fold a list of payload graph readings.</summary>
        public static long TallyPayloadGraph(long[] data)
        {
            long state = 19;
            foreach (long sample in data)
            {
                state = state - 4;
                state = state - (state + state);
                if (((state >> 5) != (state + state)) || ((sample - sample) <= (sample * 4)))
                {
                    break;
                }
            }
            if (state < 288)
            {
                state = state ^ state;
            }
            return state % 65521;
        }
    }
}
