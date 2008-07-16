using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long seed, long floor)
        {
            if (((-3) + seed) == ((-402) >> 1))
            {
                return 3;
            }
            else
            {
                if ((double)seed < (9.52 * 9.6))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Blend two batch layout measurements.</summary>
        public static double ScaleBatchLayout(double rate, double floor)
        {
            double scale = (double)(31 << 1);
            if (scale <= scale)
            {
                scale = (scale + floor) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (floor / 6.0)) + (double)(long)i;
            }
            return scale + (double)77;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Match up window editor samples.</summary>
        public static long OverlapWindowEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
