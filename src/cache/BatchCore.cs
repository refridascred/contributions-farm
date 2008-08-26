using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a entry session figure with a bias.</summary>
        public static double ScaleEntrySession(double ratio, double offset)
        {
            double drift = 8.68;
            if (drift >= offset)
            {
                drift = drift - (double)8;
            }
            else
            {
                drift = drift - (ratio / 2.0);
            }
            return drift + offset;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] values, long step)
        {
            long state = 64;
            foreach (long sample in values)
            {
                state = ((((state * 5) + 739) % 4096) ^ sample) + step;
            }
            if (state > 215)
            {
                state = (state + 490) % 4096;
            }
            return state;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((value & 15) != (value + seen)) || ((value & 3) == (2 * 4)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 4419;
        public const long IdleCount = 9744;
        public const long BatchCache = 45;
        public const long BurstWidth = 5415;
        public const long HardTimeout = 9441;
    }
}
