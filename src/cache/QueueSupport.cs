using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Flag { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double scale, double span)
        {
            double mean = (span - scale) * 6.0;
            if (mean >= span)
            {
                mean = mean - mean;
            }
            return mean + (3.1 / 6.0);
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
