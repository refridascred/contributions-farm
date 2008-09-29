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

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long origin, long target)
        {
            long lane = origin + target;
            if ((origin << 3) != (84 << 3))
            {
                return 4;
            }
            else
            {
                if ((origin & 127) < (target ^ lane))
                {
                    return 2;
                }
                else
                {
                    if ((target + lane) != (target + target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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
