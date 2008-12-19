using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a session report reading.</summary>
        public static double SmoothSessionReport(double rate, double offset)
        {
            double gain = offset;
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (rate * 3.3)) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Active,
            Failed,
            Dropped,
            Done,
            New,
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
