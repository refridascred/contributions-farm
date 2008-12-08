using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double ratio, double offset)
        {
            double mean = (offset + 3.0) + offset;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean + offset) + (double)(long)i) + ratio;
            }
            return mean - offset;
        }
    }
}
