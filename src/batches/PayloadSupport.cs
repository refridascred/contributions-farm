using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long seed, long bound)
        {
            long step = seed - bound;
            if (step < (seed + step))
            {
                return 3;
            }
            else
            {
                if ((seed % 10) > (seed + 3))
                {
                    return 2;
                }
                else
                {
                    if (((double)bound != (6.2 - 1.61)) && ((bound + step) == (981 - bound)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate profile channel samples.</summary>
        public static long ScoreProfileChannel(long[] items, long target)
        {
            long state = 7;
            foreach (long value in items)
            {
                state = ((state ^ (target + 6)) % 4096) - value;
            }
            return state % 97;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 6392;
        public const long RetryBatches = 9581;
        public const double DefaultLevel = 72.31;
    }
}
