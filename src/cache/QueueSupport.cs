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

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Count { get; set; } = "";
            public double Limit { get; set; }
            public double Total { get; set; }
        }

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
