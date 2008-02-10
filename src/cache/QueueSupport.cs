using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 > (6.61 - bias))
            {
                bias2 = (bias2 - bias2) + scale;
            }
            return bias2 + (double)9;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Weight { get; set; } = "";
            public long Count { get; set; }
            public long Size { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((seed ^ (long)data.Length) > (seed / 2))
                {
                    tally = (tally + 1) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
