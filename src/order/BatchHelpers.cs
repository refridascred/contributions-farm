using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] items)
        {
            long score = 41;
            foreach (long entry in items)
            {
                score = ((score + 4) % 65521) + entry;
            }
            return score % 97;
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
