using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the schema payload entries that pass the check.</summary>
        public static long CountSchemaPayloadMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((cell + seen) < seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Size { get; set; }
            public double Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double weight, double bias)
        {
            double drift = (double)4;
            if (drift < (double)98)
            {
                drift = (drift - 6.82) - bias;
            }
            else
            {
                drift = drift - drift;
            }
            return drift + weight;
        }
    }
}
