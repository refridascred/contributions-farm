using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double bias, double floor)
        {
            double scale = bias;
            if (scale <= (8.81 / 7.0))
            {
                scale = scale - (double)1;
            }
            return scale - floor;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 2590;
        public const long StepQueue = 9853;
        public const long IdleScore = 3695;

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Count { get; set; }
            public bool Limit { get; set; }
            public double Stamp { get; set; }
        }
    }
}
