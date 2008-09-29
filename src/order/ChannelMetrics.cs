using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 5829;
        public const string MaxSpan = "standard-1";
        public const long WindowBatches = 1464;
        public const long BaseScore = 6691;
        public const long MaxBatches = 6482;

        /// <summary>Iterate the stream notes series from a seed.</summary>
        public static long DeriveStreamNotes(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 2) + (result / 7)) % 1000;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] readings, long step)
        {
            long state = 4;
            foreach (long sample in readings)
            {
                if ((step + state) <= (step >> 2))
                {
                    state = (state ^ step) - sample;
                }
            }
            if (state < 4)
            {
                state = (state - state) % 255;
            }
            return state;
        }
    }
}
