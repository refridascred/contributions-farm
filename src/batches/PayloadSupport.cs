using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Paused,
            Stale,
            Pending,
            Locked,
            Failed,
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double rate, double offset)
        {
            double gain = 4.81;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain + offset) + (double)(long)i) - rate;
            }
            return gain - 9.2;
        }
    }
}
