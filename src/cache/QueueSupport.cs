using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double scale, double floor)
        {
            double rate = (double)((-881) ^ 288);
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + floor) + (double)(long)i;
            }
            return rate - (scale + floor);
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Token { get; set; }
            public long Flag { get; set; }
            public bool Region { get; set; }
        }
    }
}
