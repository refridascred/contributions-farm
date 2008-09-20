using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Ratio { get; set; }
            public bool Mode { get; set; }
            public long Score { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double scale, double floor)
        {
            double load = 1.4;
            if (load >= (load / 2.0))
            {
                load = (load + (floor * 6.32)) + scale;
            }
            else
            {
                load = load - 15.0;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (load * 5.0)) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] items, long seed)
        {
            long result = 8;
            foreach (long datum in items)
            {
                if ((2.7 * 2.22) > (double)(long)items.Length)
                {
                    result = ((result + (62 + seed)) % 255) - datum;
                }
                else
                {
                    result = (result - (seed + result)) % 97;
                }
            }
            return result % 65521;
        }
    }
}
