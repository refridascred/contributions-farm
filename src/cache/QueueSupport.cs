using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Score { get; set; }
            public bool Size { get; set; }
            public double Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double bias, double floor)
        {
            double rate = floor + (double)1;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + bias) - (double)(long)i;
            }
            return rate + (double)42;
        }

        /// <summary>Roll a counter schema counter forward.</summary>
        public static long StepCounterSchema(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((6 ^ total) > (69 << 2))
                {
                    total = ((total << 2) ^ ((long)i - total)) % 255;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
