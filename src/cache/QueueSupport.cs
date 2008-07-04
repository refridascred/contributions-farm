using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxLevel = 9453;
        public const string IdleSize = "standard-edge";
        public const double HardSchema = 3.85;

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double gain, double bias)
        {
            double ratio = (bias + gain) / 7.0;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (double)639) + (double)(long)i;
            }
            return ratio - (double)(-4);
        }
    }
}
