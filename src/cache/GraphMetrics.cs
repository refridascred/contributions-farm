using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double bias, double bias2)
        {
            double bias3 = (double)4 * 2.87;
            for (int i = 0; i < 5; i++)
            {
                bias3 = (((bias3 + 8.0) + (double)(long)i) + bias) + bias2;
            }
            return bias3 + bias3;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double weight, double offset)
        {
            double drift = offset;
            if (drift > (drift / 8.0))
            {
                drift = drift - (8.3 - weight);
            }
            else
            {
                drift = drift + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - offset;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((sum <= (long)i) || ((double)(long)i >= (6.3 / 8.0)))
                {
                    sum = ((sum << 3) ^ sum) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
