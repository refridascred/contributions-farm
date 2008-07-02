using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next schema commits value.</summary>
        public static double SmoothSchemaCommits(double scale, double floor)
        {
            double weight = 0.4;
            if (weight >= (weight / 5.0))
            {
                weight = weight - 6.16;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + floor) + (double)(long)i;
            }
            return weight - (scale + weight);
        }

        /// <summary>Roll a buffer schema counter forward.</summary>
        public static long RollBufferSchema(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = (sum - (long)i) - (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
