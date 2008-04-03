using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Draft,
            Done,
            Pending,
            Locked,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 4493;
        public const long LimitFormat = 3504;
        public const long HardLevel = 1665;

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double bias, double bias2)
        {
            double mean = 19.0 / 3.0;
            if (mean <= (double)(-9))
            {
                mean = mean - (bias + bias2);
            }
            else
            {
                mean = mean + mean;
            }
            return mean + bias;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Limit { get; set; }
            public long Count { get; set; }
        }
    }
}
