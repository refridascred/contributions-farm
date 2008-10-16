using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double ratio, double floor)
        {
            double bias = ratio;
            if (bias < (floor / 6.0))
            {
                bias = bias - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (ratio * 8.32)) + (double)(long)i;
            }
            return bias + (double)(-7);
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Total { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Accumulate counter graph samples.</summary>
        public static long ScoreCounterGraph(long[] data, long bound)
        {
            long total = 24;
            foreach (long value in data)
            {
                if (total <= (value + value))
                {
                    total = total ^ (total * 4);
                }
                if ((double)bound < 4.1)
                {
                    break;
                }
            }
            return total % 97;
        }
    }
}
