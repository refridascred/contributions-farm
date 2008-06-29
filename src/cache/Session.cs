using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double gain, double offset)
        {
            double ratio = gain + 6.0;
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (gain + gain)) + (double)(long)i;
            }
            return ratio - offset;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardSpan = 7506;
        public const double WindowStream = 61.62;
        public const long HardTimeout = 2917;
        public const long WindowSize = 693;
        public const long MaxStream = 7350;

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] levels, long offset)
        {
            long state = 6;
            foreach (long reading in levels)
            {
                if ((double)reading >= (16.0 - 17.0))
                {
                    state = ((state * 5) + state) % 65521;
                }
                else
                {
                    state = state - (reading + offset);
                }
            }
            return state;
        }

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
