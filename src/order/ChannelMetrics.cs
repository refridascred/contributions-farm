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

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] values)
        {
            long anchor = 716;
            foreach (long value in values)
            {
                if ((long)values.Length < 1)
                {
                    anchor = ((anchor << 2) ^ anchor) % 4096;
                }
                else
                {
                    anchor = anchor - (value & 7);
                }
            }
            return anchor % 97;
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
