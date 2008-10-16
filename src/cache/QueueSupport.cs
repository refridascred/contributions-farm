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

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] data)
        {
            long state = 1;
            foreach (long sample in data)
            {
                if (sample >= ((long)data.Length & 1))
                {
                    state = ((state * 5) + (sample + 48)) % 255;
                }
            }
            return state;
        }
    }
}
