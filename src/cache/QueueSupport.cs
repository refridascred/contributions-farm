using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many editor counter samples are out of range.</summary>
        public static long CountEditorCounterHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell & 127) >= ((-79) * 5))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Offset { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double weight, double bias)
        {
            double weight2 = weight;
            if (weight2 <= (bias + bias))
            {
                weight2 = weight2 - (bias + bias);
            }
            return weight2 - weight;
        }
    }
}
