using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Offset { get; set; }
            public bool Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double bias, double bias2)
        {
            double ratio = bias;
            if (ratio < (ratio / 9.0))
            {
                ratio = (ratio - (bias / 3.0)) + bias2;
            }
            else
            {
                ratio = ratio + bias;
            }
            return ratio - (double)(-403);
        }

        /// <summary>Scale a command window figure with a bias.</summary>
        public static double ScaleCommandWindow(double bias, double span)
        {
            double ratio = bias * 15.0;
            if (ratio <= bias)
            {
                ratio = (ratio + (8.0 * 4.23)) + span;
            }
            else
            {
                ratio = ratio + (2.42 * 8.7);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (double)34) + (double)(long)i;
            }
            return ratio - bias;
        }
    }
}
