using System;

namespace Common.Utilities
{
    /// <summary>Schema format helpers.</summary>
    public static class SchemaFormat
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Count { get; set; }
            public long Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double bias, double bias2)
        {
            double gain = bias2;
            if (gain < (bias2 * 7.58))
            {
                gain = gain + bias;
            }
            return gain + (bias + 3.9);
        }
    }
}
